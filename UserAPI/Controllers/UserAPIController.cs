using UserAPI.Model;
using UserAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace UserAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
//[Produces("application/json")]
public class UsersController : ControllerBase
{
    private readonly UserService _userService;

    public UsersController(UserService userService) =>
        _userService = userService;

    [HttpGet]
    public async Task<List<User>> Get() =>
        await _userService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<User>> Get(string id)
    {
        var user = await _userService.GetAsync(id);

        if (user is null)
        {
            return NotFound();
        }

        return user;
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<List<User>>> Search(string name)
    {
        var user = await _userService.SearchAsync(name);

        if (user is null)
        {
            return NotFound();
        }

        return user;
    }

    [HttpPost]
    public async Task<IActionResult> Post(User newUser)
    {
        if (string.IsNullOrEmpty(newUser.Email))
        {
            ModelState.AddModelError("Email", "Email is required");
            return BadRequest(ModelState);
        }
        await _userService.CreateAsync(newUser);


        return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, User updatedUser)
    {
        var user = await _userService.GetAsync(id);

        if (user is null)
        {
            return NotFound();
        }

        if (string.IsNullOrEmpty(updatedUser.Email))
        {
            ModelState.AddModelError("Email", "Email is required");
            return BadRequest(ModelState);
        }

        updatedUser.Id = user.Id;

        await _userService.UpdateAsync(id, updatedUser);

        return CreatedAtAction(nameof(Get), new { id = user.Id }, updatedUser);
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var user = await _userService.GetAsync(id);

        if (user is null)
        {
            return NotFound();
        }

        await _userService.RemoveAsync(user.Id);

        return NoContent();
    }
}
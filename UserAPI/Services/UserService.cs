﻿using UserAPI.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace UserAPI.Services;

public class UserService
{
    private readonly IMongoCollection<User> _usersCollection;

    public UserService(
        IOptions<UsersDatabaseSettings> usersDatabaseSettings)
    {
        var settings = MongoClientSettings.FromConnectionString(usersDatabaseSettings.Value.ConnectionString);
        var mongoClient = new MongoClient(settings);

        var mongoDatabase = mongoClient.GetDatabase(usersDatabaseSettings.Value.DatabaseName);

        _usersCollection = mongoDatabase.GetCollection<User>(usersDatabaseSettings.Value.UsersCollectionName);
        //Console.WriteLine(_usersCollection.Find(_ => true).ToList());
    }

    public async Task<List<User>> GetAsync() =>
        await _usersCollection.Find(_ => true).ToListAsync();

    public async Task<User?> GetAsync(string id) =>
        await _usersCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    public async Task<List<User>> SearchAsync(string name) =>
        await _usersCollection.Find(x => x.FirstName.ToLower().Contains(name.ToLower()) || x.LastName.ToLower().Contains(name.ToLower())).ToListAsync();

    public async Task CreateAsync(User newBook) =>
        await _usersCollection.InsertOneAsync(newBook);

    public async Task UpdateAsync(string id, User updatedBook) =>
        await _usersCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

    public async Task RemoveAsync(string id) =>
        await _usersCollection.DeleteOneAsync(x => x.Id == id);
}
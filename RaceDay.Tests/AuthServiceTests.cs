using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RaceDay.API.Data;
using RaceDay.API.DTOs;
using RaceDay.API.Services;
using Xunit;

namespace RaceDay.Tests
{
    public class AuthServiceTests
    {
        private RaceDayDbContext GetDb()
        {
            var options = new DbContextOptionsBuilder<RaceDayDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            return new RaceDayDbContext(options);
        }

        private IConfiguration GetConfig()
        {
            return new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string>
                {
                    { "Jwt:Key", "ThisIsAVerySecretKeyForRaceDayAPI2026!" },
                    { "Jwt:Issuer", "RaceDayAPI" },
                    { "Jwt:Audience", "RaceDayClient" }
                })
                .Build();
        }

        [Fact]
        public async Task Register_ValidUser_ReturnsToken()
        {
            var service = new AuthService(GetDb(), GetConfig());
            var result = await service.RegisterAsync(new RegisterDto
            {
                FirstName = "Test",
                LastName = "User",
                Email = "test@example.com",
                Password = "Password123!",
                Role = "Organiser"
            });

            Assert.NotNull(result);
            Assert.NotEmpty(result.Token);
            Assert.Equal("Organiser", result.Role);
        }

        [Fact]
        public async Task Register_DuplicateEmail_Throws()
        {
            var service = new AuthService(GetDb(), GetConfig());
            var dto = new RegisterDto
            {
                FirstName = "Test",
                LastName = "User",
                Email = "test@example.com",
                Password = "Password123!",
                Role = "Participant"
            };

            await service.RegisterAsync(dto);
            await Assert.ThrowsAsync<Exception>(() => service.RegisterAsync(dto));
        }

        [Fact]
        public async Task Login_ValidCredentials_ReturnsToken()
        {
            var service = new AuthService(GetDb(), GetConfig());
            await service.RegisterAsync(new RegisterDto
            {
                FirstName = "Test",
                LastName = "User",
                Email = "test@example.com",
                Password = "Password123!",
                Role = "Participant"
            });

            var result = await service.LoginAsync(new LoginDto
            {
                Email = "test@example.com",
                Password = "Password123!"
            });

            Assert.NotNull(result);
            Assert.NotEmpty(result.Token);
        }

        [Fact]
        public async Task Login_WrongPassword_Throws()
        {
            var service = new AuthService(GetDb(), GetConfig());
            await service.RegisterAsync(new RegisterDto
            {
                FirstName = "Test",
                LastName = "User",
                Email = "test@example.com",
                Password = "Password123!",
                Role = "Participant"
            });

            await Assert.ThrowsAsync<Exception>(() => service.LoginAsync(new LoginDto
            {
                Email = "test@example.com",
                Password = "WrongPassword!"
            }));
        }
    }
}
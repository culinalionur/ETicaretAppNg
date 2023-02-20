using ETicaretApp.Application.DTOs.UserDto;
using ETicaretApp.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
        Task<CreateUserResponse> CreateAsync(CreateUser model);
    }
}

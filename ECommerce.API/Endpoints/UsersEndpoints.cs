using ECommerce.API.Contracts;
using ECommerce.Application.Services;

namespace ECommerce.API.Endpoints
{
    public static class UsersEndpoints
    {
        public static IEndpointRouteBuilder MapUsersEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPost("register", Register);
            app.MapPost("login", Login);

            return app;
        }

        public static async Task<IResult> Register(RegisterUserRequest request,
            UserService userService)
        {
            await userService.Register(request.Login, request.Email, request.Password, request.FirstName, request.LastName);

            return Results.Ok();
        }

        public static async Task<IResult> Login(LoginUserRequest request, UserService userService)
        {
            var token = await userService.Login(request.Login, request.Password);

            return Results.Ok(token);
        }
    }
}

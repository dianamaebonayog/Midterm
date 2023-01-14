﻿using System.Security.Claims;

namespace EFCoreForRazorPages.Infrastructure.Security
{
    public static class UserExtension
    {
        public static string? Name(this ClaimsPrincipal user)
            => user.Identity?.Name;

        public static string? Provinces(this ClaimsPrincipal user)
            => (user.FindFirstValue("Provinces")) ?? null;

        public static Guid? Id(this ClaimsPrincipal user)
            => (Guid.TryParse(user.FindFirstValue(ClaimTypes.NameIdentifier), out var id)) ? id : null;

    }
}
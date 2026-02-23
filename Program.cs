var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();



app.MapGet("/api/v1/linktoken", () =>
{
    return Results.Json(new
    {
        content = new
        {
            linkToken = "aHR0cHM6Ly93ZWIubWVzaGNvbm5lY3QuY29tL2IyYi1pZnJhbWUve2NsaWVudElkfS9icm9rZXItY29ubmVjdD9hdXRoX2NvZGU9e2F1dGhDb2RlfQ=="
        },
        status = "ok",
        message = "",
        errorHash = "8d443794",
        teamCode = "P4",
        errorType = ""
    });
});

app.MapPost("/api/v1/token/refresh", () =>
{
    return Results.Json(new
    {
        content = new
        {
            status = "succeeded",
            expiresInSeconds = 86400,
            brokerAccountTokens = new[]
            {
                new
                {
                    accessToken = "New secret token",
                    refreshToken = "New secret refresh token"
                }
            }
        },
        status = "ok",
        message = "",
        errorHash = "9d3039e8",
        teamCode = "P4",
        errorType = ""
    });
});

app.MapDelete("/operation/status", () =>
{
    return Results.Json(new
    {
        status = "ok",
        message = "",
        errorHash = "2ed92849",
        teamCode = "P4",
        errorType = ""
    });
});

app.MapGet("/api/v1/status", () =>
{
    return Results.Json(new
    {
        content = new object[]
        {
            new
            {
                type = "robinhood",
                name = "Robinhood",
                isUp = true,
                supportedProducts = new[]
                {
                    "balance",
                    "holdings",
                    "identity",
                    "orders",
                    "transfers"
                }
            },
            new
            {
                type = "celsius",
                name = "Celsius",
                isUp = false,
                description = "Temporarily disabled",
                downTimeStart = 1655891444,
                supportedProducts = new[]
                {
                    "balance",
                    "orders",
                    "transfers",
                    "holdings"
                }
            },
            new
            {
                type = "deFiWallet",
                name = "MetaMask",
                isUp = false,
                supportedProducts = new[]
                {
                    "transfers",
                    "holdings"
                },
                deFiWalletData = new
                {
                    id = "34aeb688-decb-485f-9d80-b66466783394",
                    name = "MetaMask"
                }
            }
        },
        status = "ok",
        message = "",
        errorHash = "f585284a",
        teamCode = "P4",
        errorType = ""
    });
});

app.MapGet("/api/v1/integrations", () =>
{
    return Results.Json(new
    {
        content = new
        {
            items = new object[]
            {
                new
                {
                    id = "47624467-e52e-4938-a41a-7926b6c27acf",
                    name = "Coinbase",
                    type = "coinbase",
                    style = new
                    {
                        fieldActiveLight = "0052FF",
                        buttonPrimaryLight = "0052FF",
                        buttonHoverLight = "014CEC",
                        buttonTextLight = "FFFFFF",
                        buttonTextHoverLight = "FFFFFF",
                        fieldActiveDark = "578BFA",
                        buttonPrimaryDark = "578BFA",
                        buttonHoverDark = "507FE5",
                        buttonTextDark = "0A0B0D",
                        buttonTextHoverDark = "0A0B0D"
                    },
                    logo = new
                    {
                        logoLightUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Logo_Light.svg",
                        logoDarkUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Logo_Dark.svg",
                        logoWhiteUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Logo_White.svg",
                        logoBlackUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Logo_Black.svg",
                        logoColorUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Logo_Color.svg",
                        iconLightUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Icon_Light.svg",
                        iconDarkUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Icon_Dark.svg",
                        iconWhiteUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Icon_White.svg",
                        iconBlackUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Icon_Black.svg",
                        iconColorUrl = "https://file-cdn.meshconnect.com/public/logos/Coinbase_Icon_Color.svg",
                        base64Logo = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAMAAADXqc3KAAAA1VBMVEUAAAAAgP8AVf8AM/8AVdUAROgAQ+kAROkAROkAQ+oAQuoAROoAQ+gAROkAQ+kAQ+kAROkAQ+kAQ+kAROkAQugAQ+kAQ+kAROkAQ+kAQ+kAQ+kAQ+kAQ+kXVesOTuoAQ+kBROkERukFR+kNTeoOTeoUUusZVeshW+wpYe0qYu0uZe0yaO00ae05be5fifFgivGMqvWSr/amvfeqwPi7zfnE0/rO2/vU3/vY4vzc5fze5/zh6fzi6vzl7P3m7f3p7/3u8v7x9f73+f75+/76+//+/v////94Z10/AAAAH3RSTlMAAgMFBk9QUlNUVVZXiImKi4ykptfY2dvc3fHz9Pr8ZrpFhQAAAAFiS0dERhe6+e0AAADPSURBVBgZncHXVsJAFAXQExM6UhJCwEGPYsfesKCiAvf/P8m5swIhPLI3thbUo3gwiKNagJxyn6leCZmdNte0PCy1mdNAqswNRThBn+r0/n3+/XRAKwmg6lTnnyI/s2c6VaiI6kVerzg8phNCdWmNZHHBlRjK0LqVCTMGytC6kwkze1BdWteyGHElhopoHY7l7YZHJ3RCqBrV5VTk9288pKpABT2qs4eP2dfjPq3Eh1PihgJSLebsYslrck3DQ6aYMJUUkONXw44xnbDiY1v/vNIqVzlyMewAAAAASUVORK5CYII="
                    },
                    cryptoTransfersSupported = true
                },
                new
                {
                    id = "3d8f5c31-9fc0-4b61-bdfb-00fb18cbb9ad",
                    name = "CoinCircle",
                    type = "deFiWallet",
                    deFiWalletProviderId = "36d8d9c0c7fe2957149ce8e878f3a01...",
                    categories = new[]
                    {
                        "deFiWallet"
                    },
                    style = new
                    {
                        fieldActiveLight = "0052FF",
                        buttonPrimaryLight = "0052FF",
                        buttonHoverLight = "014CEC",
                        buttonTextLight = "FFFFFF",
                        buttonTextHoverLight = "FFFFFF",
                        fieldActiveDark = "578BFA",
                        buttonPrimaryDark = "578BFA",
                        buttonHoverDark = "507FE5",
                        buttonTextDark = "0A0B0D",
                        buttonTextHoverDark = "0A0B0D"
                    },
                    logo = new
                    {
                        logoColorUrl = "https://file-cdn.meshconnect.com/public/logos/CoinCircle_Logo_Color.svg",
                        iconColorUrl = "https://file-cdn.meshconnect.com/public/logos/CoinCircle_Icon_Color.svg"
                    },
                    cryptoTransfersSupported = true
                }
            }
        },
        status = "ok",
        message = "",
        errorHash = "d48f676e",
        teamCode = "P4",
        errorType = ""
    });
});

app.Run();



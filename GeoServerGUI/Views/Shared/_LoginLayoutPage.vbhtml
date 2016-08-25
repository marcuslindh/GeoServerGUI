<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login - GeoServer GUI</title>

    <link href="~/css/App.css" rel="stylesheet" />
</head>
<body>
    <header>
        <h1>GeoServer GUI</h1>
    </header>
    <div class="page">
        <section>
            @RenderBody()

            <footer>
                Version: @GetType(User).Assembly.GetName().Version.ToString               
            </footer>
        </section>
    </div>
</body>
</html>
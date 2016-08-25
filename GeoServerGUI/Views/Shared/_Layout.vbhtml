<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - GeoServer GUI</title>

    <link href="~/css/App.css" rel="stylesheet" />
    <link href="~/css/Frame.css" rel="stylesheet" />
</head>
<body>
    <header>
        <span id="MenuButton" class="button">Menu</span>
        <h1>GeoServer GUI</h1>
    </header>
    <div class="page">
        <div id="Block"></div>
        <aside id="SideBar">
            <h3>Server-status</h3>
            <ul>
                <li>GeoServer-loggar</li>
                <li>Kontaktinformation</li>
                <li>Om GeoServer</li>
            </ul>
            <h3>Data</h3>
            <ul>
                <li>Förhandsvy lager</li>
                <li>Arbetsytor</li>
                <li>Förråd</li>
                <li>Lager</li>
                <li><a href="~/Layergroups">Lagergrupper</a></li>
                <li>Stilar</li>
            </ul>

            <h3>Tjänster</h3>
            <ul>
                <li>WCS</li>
                <li>WFS</li>
                <li>WMS</li>
            </ul>
            <h3>Inställningar</h3>
            <ul>
                <li>Global</li>
                <li>JAI</li>
                <li>Coverage Access</li>
            </ul>
            <h3>Tile-cachelagring</h3>
            <ul>
                <li>Tile-lager</li>
                <li>Cachelagringsstandard</li>
                <li>Gridsets</li>
                <li>Diskkvot</li>
                <li>BlobStores</li>
            </ul>
            <h3>Säkerhet</h3>
            <ul>
                <li>Inställningar</li>
                <li>Verifiering</li>
                <li>Lösenord</li>
                <li>Användare, Grupper, Roller</li>
                <li>Data</li>
                <li>Tjänster</li>
            </ul>
        </aside>

        <section>
            @RenderBody()

            <footer>
                Version: @GetType(User).Assembly.GetName().Version.ToString
                <a href="/Logout">Logout</a>
            </footer>
        </section>


    </div>
    <script src="~/js/jquery.js"></script>
    <script src="~/js/Start.js"></script>
    <script src="~/js/SideBar.js"></script>
</body>
</html>
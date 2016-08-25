@Code
    Layout = "~/Views/Shared/_LoginLayoutPage.vbhtml"
End Code

<form id="LoginForm" action="Login/login" method="post">
    <label>
        Username:
        <input type="text" name="user" value="" />
    </label>
    <label>
        Password:
        <input type="password" name="password" value="" />
    </label>
    <button type="submit">Login</button>
</form>
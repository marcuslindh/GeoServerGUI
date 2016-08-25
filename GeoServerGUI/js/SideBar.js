

document.getElementById("MenuButton").addEventListener("click", function () {
    document.getElementById("SideBar").classList.add("show");
    document.getElementById("Block").classList.add("show");
});

document.getElementById("Block").addEventListener("click", function () {
    document.getElementById("SideBar").classList.remove("show");
    document.getElementById("Block").classList.remove("show");
});
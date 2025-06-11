// Move the red box across the screen
let box = document.getElementById("box");
let pos = 0;

function moveBox() {
    if (pos >= 300) {
        pos = 0;
    } else {
        pos += 2;
        box.style.left = pos + 'px';
    }
    requestAnimationFrame(moveBox);
}

moveBox();

// === Lightbox Functionality ===
document.addEventListener("DOMContentLoaded", function () {
    const lightbox = document.getElementById("lightbox");
    const lightboxImg = document.getElementById("lightbox-img");
    const closeBtn = document.querySelector(".close");

    const links = document.querySelectorAll(".lightbox-link");

    links.forEach(link => {
        link.addEventListener("click", function (e) {
            e.preventDefault();
            const imgSrc = this.querySelector("img").src;
            lightboxImg.src = imgSrc;
            lightbox.style.display = "block";
        });
    });

    closeBtn.addEventListener("click", function () {
        lightbox.style.display = "none";
        lightboxImg.src = "";
    });

    // Optional: Close lightbox when clicking outside the image
    lightbox.addEventListener("click", function (e) {
        if (e.target === lightbox) {
            lightbox.style.display = "none";
            lightboxImg.src = "";
        }
    });
});

// === Smooth Scrolling for Navigation (Optional) ===
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener("click", function (e) {
        e.preventDefault();
        const target = document.querySelector(this.getAttribute("href"));
        if (target) {
            target.scrollIntoView({
                behavior: "smooth",
                block: "start"
            });
        }
    });
});

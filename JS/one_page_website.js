document.addEventListener('DOMContentLoaded', function () {
    const lightbox = document.getElementById('lightbox');
    const lightboxImg = document.getElementById('lightbox-img');
    const links = document.querySelectorAll('.lightbox-link');
  
    links.forEach(link => {
      link.addEventListener('click', function (e) {
        e.preventDefault();
        lightbox.style.display = 'block';
        lightboxImg.src = this.href;
      });
    });
  
    document.querySelector('.close').addEventListener('click', function () {
      lightbox.style.display = 'none';
    });
  
    lightbox.addEventListener('click', function (e) {
      if (e.target === lightbox) {
        lightbox.style.display = 'none';
      }
    });
  });
  
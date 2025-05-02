// JavaScript: observe each section and add 'visible' when scrolled into view
const observer = new IntersectionObserver((entries, obs) => {
    entries.forEach(entry => {
      if (entry.isIntersecting) {
        entry.target.classList.add('visible');
        obs.unobserve(entry.target);
      }
    });
  }, { threshold: 0.1 });
  
  document.querySelectorAll('.fade-section').forEach(sec => {
    observer.observe(sec);
  });
  
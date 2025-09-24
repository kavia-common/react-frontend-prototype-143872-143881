(function () {
  'use strict';

  var storageKey = 'ocean-theme';
  var btn = null;

  function getSavedTheme() {
    try {
      var v = localStorage.getItem(storageKey);
      return v === 'dark' ? 'dark' : 'light';
    } catch (e) {
      return 'light';
    }
  }

  function setTheme(theme) {
    document.documentElement.setAttribute('data-theme', theme);
    try {
      localStorage.setItem(storageKey, theme);
    } catch (e) {}
    updateToggleButton(theme);
    // Dispatch a custom event so pages can react to theme changes
    var evt = new CustomEvent('themechange', { detail: { theme: theme } });
    document.dispatchEvent(evt);
  }

  function toggleTheme() {
    var current = document.documentElement.getAttribute('data-theme') || 'light';
    setTheme(current === 'light' ? 'dark' : 'light');
  }

  function updateToggleButton(theme) {
    if (!btn) return;
    var icon = btn.querySelector('.icon');
    var text = btn.querySelector('.text');
    if (theme === 'dark') {
      if (icon) icon.textContent = '☀️';
      if (text) text.textContent = 'Light';
      btn.setAttribute('aria-label', 'Switch to light theme');
    } else {
      if (icon) icon.textContent = '🌙';
      if (text) text.textContent = 'Dark';
      btn.setAttribute('aria-label', 'Switch to dark theme');
    }
  }

  function init() {
    // Initialize theme from storage or default
    var initial = getSavedTheme();
    setTheme(initial);

    // Wire up the toggle button
    btn = document.getElementById('themeToggle');
    if (btn) {
      btn.addEventListener('click', toggleTheme);
      updateToggleButton(initial);
    }
  }

  if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', init);
  } else {
    init();
  }
})();

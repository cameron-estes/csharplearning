const getWeatherBtn = document.getElementById('getWeatherBtn');
const weatherInfo = document.getElementById('weatherInfo');
const loading = document.getElementById('loading');

getWeatherBtn.addEventListener('click', async () => {
    // callls getCurrentPosition() which uses navigator.geolocation.getCurrentPosition() to get the position
    const position = await getCurrentPosition();
    const { latitude, longitude } = position.coords;

    const weatherData = await fetchWeatherData(latitude, longitude);
    displayWeather(weatherData, latitude, longitude);
});

function getCurrentPosition() {
    return new Promise((resolve, reject) => {
        navigator.geolocation.getCurrentPosition(
            resolve, reject, {enableHighAccuracy: true}
        );
    });
}

async function fetchWeatherData(lat, lon) {
    try {
        const response = await fetch(`/weather?lat=${lat}&lon=${lon}`);

        if (!response.ok) {
            const errorText = await response.text();
            throw new Error(`Weather API error: ${errorText}`);
        }

        return await response.json();
    } catch (err) {
        throw new Error(`Failed to fetch weather data: ${err.message}`);
    }
}

function displayWeather(data, lat, lon) {
    try {
        const weather = JSON.parse(data);

        document.getElementById('location').textContent = `${weather.name}, ${weather.sys.country}`;
        document.getElementById('temperature').textContent = `${Math.round(weather.main.temp)}°C`;
        document.getElementById('description').textContent = weather.weather[0].description;
        document.getElementById('feelsLike').textContent = `${Math.round(weather.main.feels_like)}°C`;
        document.getElementById('humidity').textContent = `${weather.main.humidity}%`;
        document.getElementById('windSpeed').textContent = `${weather.wind.speed} m/s`;
        document.getElementById('coordinates').textContent = `${lat.toFixed(4)}, ${lon.toFixed(4)}`;

        weatherInfo.style.display = 'block';
    } catch (err) {
        throw new Error(`Failed to parse weather data: ${err.message}`);
    }
}

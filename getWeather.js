const axios = require('axios');
const city = 'tonga';

async function getWeather() {
    const url = `https://wttr.in/${city}?format=%C=%t`;

    try{
        const response = await axios.get(url);
        console.log(`today weather in ${city}: ${response.data}`);
    } catch (error){
        console.log('could not fetch weather data', error.message)
    }
}
getWeather();
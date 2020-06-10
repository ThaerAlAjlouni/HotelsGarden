# Hotels Garden [![Build Status](https://travis-ci.org/ThaerAlAjlouni/HotelsGarden.svg?branch=master)](https://travis-ci.org/ThaerAlAjlouni/HotelsGarden)
A test app built over [Expedia's test API](https://offersvc.expedia.com/offers/v2/getOffers?scenario=deal-finder&page=foo&uid=foo&productType=Hotel), you can see it live on [heroku](https://hotels-garden.herokuapp.com/)

# Setup Instructions

You need .Net core 2.0 installed.

First run `dotnet restore`, to get all packages.  
Second, run `dotnet build`, to get the app ready.  
Then run `dotnet run`,  there should be a link telling you where to find your running localhost application. And that is it, Enjoy :)

# Known issues

The search form needs validaiton, as an example there are currently no restrictions if the `max` value is lower than the `min` value!

# Basic example for PHP API endpoint with various clients

## Blog post
Check my blog post about this topic to better understand: https://siposm.hu/blog/creating-basic-php-api

## API Usage
### Endpoint basic
- endpoint.php should be hosted under any webserver (eg. Apache (Xampp or Wamp is fine too if you are working on localhost))
- endpoint.php *currently, at the time of writing this* is available at https://siposm.hu/demo/api/endpoint.php

### Endpoint filtered
- with GET parameter you can filter for the *age*
- example: http://localhost/basic-php-api-endpoint/endpoint.php?age=22 >> this should return only Claudia and Kevin objects

### Endpoint live
- basic: https://siposm.hu/demo/api/endpoint.php
- filtered: https://siposm.hu/demo/api/endpoint.php?age=22

## Client Usage
### Client #1: C# Console Application
- using `WebClient` and `Newtonsoft JsonConvert` simple downloading the json content from the API and then processing it
- simply writing out to the console the objects

### Client #2: C# WPF Application
- using the same tools like in the console, but
- adding all the objects to a listbox
- two dedicated buttons
    - fetch all
    - fetch by age (hardcoded: only fetch 22 year olds)

### Client #3: VueJS Application
- simple vue app for prototyping
- using simple CDN sources
- logging to console and paragraphs
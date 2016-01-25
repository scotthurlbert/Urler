# Urler
Saves a URL, redirects to a URL

This may be the stupidest project I've ever created.  When you hit it with a url, it saves the url.  Later, you can hit it and it will redirect you to that url.

That's it.

Why?  Well I have a computer in the kitchen.  I wanted to be able to send a url from my other computers to this computer without syncing bookmarks.

This little web app does that in about 10 lines of code.

# To Use

Create a bookmarklet named "SaveUrl" that has this code (be sure to replace "YOUR_DEPLOYMENT_ADDRESS_HERE" with the actual location of the site):

javascript:(function(){var newURI='http://YOUR_DEPLOYMENT_ADDRESS_HERE/Urler/Home/SaveUrl?url='+encodeURIComponent(window.location.href);window.location=newURI;})()

Then when you want to get back to the url, hit:

http://YOUR_DEPLOYMENT_ADDRESS_HERE/Urler/Home/GotoUrl

# NOTE:

There is no persistence here.  I just made the url a static property.  As soon as your app pool recycles or your IIS dozes off, your url is gone.  Redeploy, gone.

It would take about 30 seconds to add persistence so have at it.

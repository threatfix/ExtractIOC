ExtractIOC
===============

[![ThreatFix](http://cdn1.editmysite.com/uploads/5/1/4/0/51408561/background-images/1387838909.png)]

A [capybara](https://github.com/jnicklas/capybara) driver that uses [WebKit](http://webkit.org) via [QtWebKit](http://trac.webkit.org/wiki/QtWebKit).

Qt Dependency and Installation Issues
-------------------------------------

capybara-webkit depends on a WebKit implementation from Qt, a cross-platform
development toolkit. You'll need to download the Qt libraries to build and
install the gem. You can find instructions for downloading and installing QT on
the
[capybara-webkit wiki](https://github.com/thoughtbot/capybara-webkit/wiki/Installing-Qt-and-compiling-capybara-webkit).
capybara-webkit requires Qt version 4.8 or greater.

Windows Support
---------------

Currently 32-bit Windows will compile capybara-webkit. Support for Windows is
provided by the open source community and Windows related issues should be
posted to [Stack Overflow].

[Stack Overflow]: http://stackoverflow.com/questions/tagged/capybara-webkit

Reporting Issues
----------------

Without access to your application code we can't easily debug most crashes or
generic failures, so we've included a debug version of the driver that prints a
log of what happened during each test. Before filing a crash bug, please see
[Reporting Crashes]. You're much more likely to get a fix if you follow those
instructions.

If you're having trouble compiling or installing, please check out the [wiki].
If you don't have any luck there, please post to [Stack Overflow]. Please don't
open a Github issue for a system-specific compiler issue.

[Reporting Crashes]: https://github.com/thoughtbot/capybara-webkit/wiki/Reporting-Crashes
[capybara-webkit wiki]: https://github.com/thoughtbot/capybara-webkit/wiki
[Stack Overflow]: http://stackoverflow.com/questions/tagged/capybara-webkit

CI
--

If you're like us, you'll be using capybara-webkit on CI.

On Linux platforms, capybara-webkit requires an X server to run, although it doesn't create any visible windows. Xvfb works fine for this. You can setup Xvfb yourself and set a DISPLAY variable, try out the [headless gem](https://github.com/leonid-shevtsov/headless), or use the xvfb-run utility as follows:

```
xvfb-run -a bundle exec spec
```

This automatically sets up a virtual X server on a free server number.

Usage
-----

Add the capybara-webkit gem to your Gemfile:

```ruby
gem "capybara-webkit"
```

Set your Capybara Javascript driver to webkit:

```ruby
Capybara.javascript_driver = :webkit
```

In cucumber, tag scenarios with @javascript to run them using a headless WebKit browser.

In RSpec, use the `:js => true` flag. See the [capybara documentation](http://rubydoc.info/gems/capybara#Using_Capybara_with_RSpec) for more information about using capybara with RSpec.

Take note of the transactional fixtures section of the [capybara README](https://github.com/jnicklas/capybara/blob/master/README.md).

If you're using capybara-webkit with Sinatra, don't forget to set

```ruby
Capybara.app = MySinatraApp.new
```

Configuration
-------------

You can configure global options using `Capybara::Webkit.configure`:

``` ruby
Capybara::Webkit.configure do |config|
  # Enable debug mode. Prints a log of everything the driver is doing.
  config.debug = true

  # By default, requests to outside domains (anything besides localhost) will
  # result in a warning. Several methods allow you to change this behavior.

  # Silently return an empty 200 response for any requests to unknown URLs.
  config.block_unknown_urls

  # Allow pages to make requests to any URL without issuing a warning.
  config.allow_unknown_urls

  # Allow a specific domain without issuing a warning.
  config.allow_url("example.com")

  # Allow a specific URL and path without issuing a warning.
  config.allow_url("example.com/some/path")

  # Wildcards are allowed in URL expressions.
  config.allow_url("*.example.com")

  # Silently return an empty 200 response for any requests to the given URL.
  config.block_url("example.com")

  # Timeout if requests take longer than 5 seconds
  config.timeout = 5

  # Don't raise errors when SSL certificates can't be validated
  config.ignore_ssl_errors

  # Don't load images
  config.skip_image_loading

  # Use a proxy
  config.use_proxy(
    host: "example.com",
    port: 1234,
    user: "proxy",
    pass: "secret"
  )
end
``

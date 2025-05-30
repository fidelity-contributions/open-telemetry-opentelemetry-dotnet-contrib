# Changelog

## Unreleased

## 1.12.0-beta.1

Released 2025-May-06

* Updated OpenTelemetry core component version(s) to `1.12.0`.
  ([#2725](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/2725))

## 1.11.0-beta.2

Released 2025-Mar-05

* Updated OpenTelemetry core component version(s) to `1.11.2`.
  ([#2582](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/2582))

## 1.11.0-beta.1

Released 2025-Jan-27

* Updated OpenTelemetry core component version(s) to `1.11.1`.
  ([#2477](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/2477))

## 1.10.0-beta.1

Released 2024-Dec-09

* Drop support for .NET 6 as this target is no longer supported
  and add .NET 8/.NET Standard 2.0 targets.
  ([#2169](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/2169))

* Updated OpenTelemetry core component version(s) to `1.10.0`.
  ([#2317](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/2317))

## 0.1.0-alpha.4

Released 2024-Sep-09

* Add a fallback mechanism for `build.id` for Linux.
  ([#2047](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/2047))

## 0.1.0-alpha.3

Released 2024-Aug-30

* Implement
  `os.build_id`,
  `os.description`,
  `os.name`,
  `os.version` attributes in
  `OpenTelemetry.ResourceDetectors.OperatingSystem`.
  ([#1983](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1983))

## 0.1.0-alpha.2

Released 2024-Jul-22

* Fix detection of macOS which was wrongly identified as Linux.
  ([#1965](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1965))

## 0.1.0-alpha.1

Released 2024-Jul-11

* Initial release of
  `OpenTelemetry.ResourceDetectors.OperatingSystem`
  project.
  ([#1943](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1943))

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
  ([#2170](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/2170))

* Updated OpenTelemetry core component version(s) to `1.10.0`.
  ([#2317](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/2317))

## 0.1.0-beta.3

Released 2024-Sep-25

* Properly dispose of System.Diagnostics.Process class instances
  ([#2101](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/2101))

## 0.1.0-beta.2

Released 2024-Jun-18

* Updated OpenTelemetry core component version(s) to `1.9.0`.
  ([#1888](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1888))

## 0.1.0-beta.1

Released 2024-Jun-04

* **Breaking Change**: Renamed package from `OpenTelemetry.ResourceDetectors.Process`
  to `OpenTelemetry.Resources.Process`.
  ([#1717](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1717))

* **Breaking Change**: `ProcessDetector` type is now internal, use `ResourceBuilder`
  extension method `AddProcessDetector` to enable the detector.
  ([#1717](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1717))

* Update OpenTelemetry SDK version to `1.8.1`.
  ([#1668](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1668))

## 0.1.0-alpha.3

Released 2024-Apr-05

* Added `process.owner` attribute.
  ([#1608](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1608))

* Update OpenTelemetry SDK version to `1.8.0`.
  ([#1635](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1635))

## 0.1.0-alpha.2

Released 2024-Jan-03

* Update OpenTelemetry SDK version to `1.7.0`.
  ([#1518](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1518))

## 0.1.0-alpha.1

Released 2023-Dec-21

* Initial release of `OpenTelemetry.ResourceDetectors.Process` project
  [1506](https://github.com/open-telemetry/opentelemetry-dotnet-contrib/pull/1506)

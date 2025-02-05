# Changelog

All notable changes to this project are documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).
This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased](https://github.com/open-telemetry/opentelemetry-dotnet-instrumentation/compare/v0.1.0-beta.1...HEAD)

### Added

- Adds MongoDB instrumentation support from .NET Core 3.1+.
- Support for OpenTelemetry metric exporter related environment variables:
  `OTEL_DOTNET_AUTO_METRICS_ENABLED`,
  `OTEL_DOTNET_AUTO_LOAD_METER_AT_STARTUP`,
  `OTEL_METRICS_EXPORTER`,
  `OTEL_DOTNET_AUTO_METRICS_CONSOLE_EXPORTER_ENABLED`,
  `OTEL_DOTNET_AUTO_METRICS_ENABLED_INSTRUMENTATIONS`,
  `OTEL_DOTNET_AUTO_METRICS_DISABLED_INSTRUMENTATIONS`,
  `OTEL_DOTNET_AUTO_METRICS_PLUGINS`,
  `OTEL_DOTNET_AUTO_METRICS_ADDITIONAL_SOURCES`.
- Support for .NET Runtime metrics collection using
  the `OpenTelemetry.Instrumentation.Runtime` package.

### Changed

- Raname generic environment variables to include trace.

  `OTEL_DOTNET_AUTO_ENABLED`&#8594;`OTEL_DOTNET_AUTO_TRACES_ENABLED`
  `OTEL_DOTNET_AUTO_LOAD_AT_STARTUP`&#8594;`OTEL_DOTNET_AUTO_LOAD_TRACER_AT_STARTUP`
  `OTEL_DOTNET_AUTO_CONSOLE_EXPORTER_ENABLED`&#8594;`OTEL_DOTNET_AUTO_TRACES_CONSOLE_EXPORTER_ENABLED`
  `OTEL_DOTNET_AUTO_ENABLED_INSTRUMENTATIONS`&#8594;`OTEL_DOTNET_AUTO_TRACES_ENABLED_INSTRUMENTATIONS`
  `OTEL_DOTNET_AUTO_DISABLED_INSTRUMENTATIONS`&#8594;`OTEL_DOTNET_AUTO_TRACES_INSTRUMENTATION_PLUGINS`
  `OTEL_DOTNET_AUTO_INSTRUMENTATION_PLUGINS`&#8594;`OTEL_DOTNET_AUTO_TRACES_INSTRUMENTATION_PLUGINS`
  `OTEL_DOTNET_AUTO_ADDITIONAL_SOURCES`&#8594;`OTEL_DOTNET_AUTO_TRACES_ADDITIONAL_SOURCES`
  
### Removed

- Support for .NET 5.0

## [0.1.0-beta.1](https://github.com/open-telemetry/opentelemetry-dotnet-instrumentation/releases/tag/v0.1.0-beta.1)

The is an initial, official beta release,
built on top of [OpenTelemetry .NET](https://github.com/open-telemetry/opentelemetry-dotnet):

- [Core components](https://github.com/open-telemetry/opentelemetry-dotnet/blob/main/VERSIONING.md#core-components):
  [`1.2.0`](https://github.com/open-telemetry/opentelemetry-dotnet/releases/tag/core-1.2.0)
- Non-core components: [`1.0.0-rc9.2`](https://github.com/open-telemetry/opentelemetry-dotnet/releases/tag/1.0.0-rc9.2)
- `System.Diagnostics.DiagnosticSource`: [`6.0.0`](https://www.nuget.org/packages/System.Diagnostics.DiagnosticSource/6.0.0)

### Added

- Support for .NET Framework 4.6.2 and higher.
- Support for .NET Core 3.1.
- Support for .NET 5.0 and 6.0.
- ASP.NET and ASP.NET Core source instrumentations.
- [GraphQL](https://www.nuget.org/packages/GraphQL/) bytecode instrumentation.
- [Microsoft.Data.SqlClient](https://www.nuget.org/packages/Microsoft.Data.SqlClient)
  and [System.Data.SqlClient](https://www.nuget.org/packages/System.Data.SqlClient)
  source instrumentation.
- OTLP, Jaeger, Zipkin and Console trace exporters.
- Global management using environment variables:
  `OTEL_DOTNET_AUTO_HOME`, `OTEL_DOTNET_AUTO_ENABLED`,
  `OTEL_DOTNET_AUTO_INCLUDE_PROCESSES`, `OTEL_DOTNET_AUTO_EXCLUDE_PROCESSES`,
  `OTEL_DOTNET_AUTO_AZURE_APP_SERVICES`.
- Support for OpenTelemetry resource environment variables:
  `OTEL_RESOURCE_ATTRIBUTES`, `OTEL_SERVICE_NAME`.
- Instrumentation management using environment variables:
  `OTEL_DOTNET_AUTO_INTEGRATIONS_FILE`, `OTEL_DOTNET_AUTO_ENABLED_INSTRUMENTATIONS`,
  `OTEL_DOTNET_AUTO_DISABLED_INSTRUMENTATIONS`,
  `OTEL_DOTNET_AUTO_{0}_ENABLED`,
  `OTEL_DOTNET_AUTO_DOMAIN_NEUTRAL_INSTRUMENTATION`,
  `OTEL_DOTNET_AUTO_CLR_DISABLE_OPTIMIZATIONS`,
  `OTEL_DOTNET_AUTO_CLR_ENABLE_INLINING`,
  `OTEL_DOTNET_AUTO_CLR_ENABLE_NGEN`.
- Support for OpenTelemetry exporter related environment variables:
  `OTEL_TRACES_EXPORTER`,
  `OTEL_EXPORTER_OTLP_PROTOCOL`,
- Customization and plugin capabilities which can be configured
  using the following environment variables:
  `OTEL_DOTNET_AUTO_LOAD_AT_STARTUP`,
  `OTEL_DOTNET_AUTO_ADDITIONAL_SOURCES`,
  `OTEL_DOTNET_AUTO_LEGACY_SOURCES`,
  `OTEL_DOTNET_AUTO_INSTRUMENTATION_PLUGINS`.
- `OTEL_DOTNET_AUTO_HTTP2UNENCRYPTEDSUPPORT_ENABLED` environment variable
  which enables `System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport`.
  See the [official Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/grpc/troubleshoot?view=aspnetcore-6.0#call-insecure-grpc-services-with-net-core-client)
  for more details.

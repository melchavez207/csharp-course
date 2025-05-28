﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductExportApp.Cli;
using ProductExportApp.Interfaces;
using ProductExportApp.Services;

var builder = Host.CreateApplicationBuilder(args);
var services = builder.Services;

services.AddSingleton<IProductExporter, JsonExporter>();
services.AddSingleton<IProductExporter, CsvExporter>();
services.AddSingleton<IProductExporter, XmlExporter>();
// TODO: Add exporter for YAML format
services.AddSingleton<IExporterFactory, ExporterFactory>();
services.AddSingleton<ProductExportCli>();

using var host = builder.Build();
host.Services.GetRequiredService<ProductExportCli>().Run(args);

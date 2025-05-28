﻿using InvoiceApp.Cli;
using InvoiceApp.Interfaces;
using InvoiceApp.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = Host.CreateApplicationBuilder(args);
var services = builder.Services;

services.AddSingleton<IInvoiceParser, InvoiceParser>();
services.AddSingleton<IInvoiceCalculator, InvoiceCalculator>();
services.AddSingleton<IReportFormatter, AsciiReportFormatter>();
services.AddSingleton<InvoiceCli>();

using var host = builder.Build();

var sampleJson = "[{\"Id\":1,\"Customer\":\"John Doe\",\"Amount\":100.50,\"Date\":\"2023-10-01\"},{\"Id\":2,\"Customer\":\"Jane Smith\",\"Amount\":200.75,\"Date\":\"2023-10-02\"}]";

if (args.Length == 0)
{
  args = [sampleJson];
}

host.Services.GetRequiredService<InvoiceCli>().Run(args);
// OPTIONAL: Create the diagram of the classes and interfaces
//           Attach an image of the diagram to your fork at the README.md level
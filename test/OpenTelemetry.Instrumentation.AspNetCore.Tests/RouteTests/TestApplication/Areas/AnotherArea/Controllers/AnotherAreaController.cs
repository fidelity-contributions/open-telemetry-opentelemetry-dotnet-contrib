// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

using Microsoft.AspNetCore.Mvc;

namespace RouteTests.Controllers;

[Area("AnotherArea")]
public class AnotherAreaController : Controller
{
    public IActionResult Index() => this.Ok();
}

// See https://aka.ms/new-console-template for more information
using System;

var vacationRequestFromManager = new Vacation()
{
    RequestData = "Trip to Paris",
    isFromManager = true,
    Days = 100
};

var vacationRequest = new Vacation()
{
    RequestData = "Trip to Africa",
    isFromManager = false,
    Days = 3
};

var simpleManagaer = new SimpleManager();
var departmentManager = new DepartmentManager();
var topManager = new TopManager();

simpleManagaer.Successor = departmentManager;
departmentManager.Successor = topManager;

simpleManagaer.Approve(vacationRequestFromManager);
simpleManagaer.Approve(vacationRequest);

Console.WriteLine(vacationRequest.ToString());
Console.WriteLine(vacationRequestFromManager.ToString());

Console.ReadKey();


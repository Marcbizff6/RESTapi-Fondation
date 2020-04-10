
# REST API
-----------------------------------------------------------------
Retrieving all interventions

GET
https://rocketelev.azurewebsites.net/api/interventions/get/status/all

-----------------------------------------------------------------
Retrieving intervention of a specific {id}

GET
https://rocketelev.azurewebsites.net/api/interventions/get/status/{id}

-----------------------------------------------------------------
Retrieving interventions that are not pending and not started

GET
https://rocketelev.azurewebsites.net/api/interventions/get/status/!pending!started

-----------------------------------------------------------------
Changing the interventions status to "InProgress" of an {id}

PUT
https://rocketelev.azurewebsites.net/api/interventions/put/inprogress/{id}

The status is automatically update to "InProgress" and the date_start is
updated to the current day and time.

IN THE BODY :

    {}

-----------------------------------------------------------------

Changing the interventions status to "Completed" of an {id}

PUT
https://rocketelev.azurewebsites.net/api/interventions/put/completed/{id}

The status is automatically update to "Completed" and the end_start is
updated to the current day and time.

IN THE BODY :

    {}

-----------------------------------------------------------------
Retrieving the current status of a specific Battery

GET
https://rocketelev.azurewebsites.net/api/batteries/{id}

-----------------------------------------------------------------

Changing the status of a specific Battery

PUT
https://rocketelev.azurewebsites.net/api/batteries/{id}

IN THE BODY :

    {
        "status": "ENTER THE NEW STATUS"
    }

-----------------------------------------------------------------

Retrieving the current status of a specific Column

GET
https://rocketelev.azurewebsites.net/api/columns/{id}

-----------------------------------------------------------------
Changing the status of a specific Column

PUT
https://rocketelev.azurewebsites.net/api/columns/{id}

IN THE BODY : 

    {
        "status": "ENTER THE NEW STATUS"
    }


-----------------------------------------------------------------
Retrieving the current status of a specific Elevator

GET
https://rocketelev.azurewebsites.net/api/elevators/{id}

-----------------------------------------------------------------

Changing the status of a specific Elevator

PUT 
https://rocketelev.azurewebsites.net/api/elevator/{id}

IN THE BODY : 

    {
        
      "status":"ENTER THE NEW STATUS"
    }

-----------------------------------------------------------------

Retrieving a list of Elevators that are not in operation at the time of the request

GET 
https://rocketelev.azurewebsites.net/api/elevators/


-----------------------------------------------------------------
Retrieving a list of Buildings that contain at least one battery, column or elevator requiring intervention

GET 

https://rocketelev.azurewebsites.net/api/buildings/intervention

-----------------------------------------------------------------
Retrieving a list of Leads created in the last 30 days who have not yet become customers.

https://rocketelev.azurewebsites.net/api/leads/listofleads


----------------------------------------------------------------- 

                          +++Extra+++
Retrieving a list of Employees with id, email and title

GET

https://rocketelev.azurewebsites.net/api/employees

----------------------------------------------------------------- 

Retrieving the current status of a specific Employee

GET
https://rocketelev.azurewebsites.net/api/employee/{id}

----------------------------------------------------------------- 
Changing the title of a specific Employee

PUT 
https://rocketelev.azurewebsites.net/api/elevator/{id}

IN THE BODY : 

    {
        
      "job_title":"ENTER THE NEW STATUS"
    }


----------------------------------------------------------------- 

Retrieving all Elevators with an "Active" status
GET
https://rocketelev.azurewebsites.net/api/elevators/get/status/active
-----------------------------------------------------------------
Retrieving all Elevators with an "Inactive" status
GET
https://rocketelev.azurewebsites.net/api/elevators/get/status/inactive
----------------------------------------------------------------- 
Retrieving all Elevators with an "Intervention" status
GET
https://rocketelev.azurewebsites.net/api/elevators/get/status/intervention
-----------------------------------------------------------------
Retrieving all Elevators with an "Others" status
GET
https://rocketelev.azurewebsites.net/api/elevators/get/status/others
-----------------------------------------------------------------
Columns
-----------------------------------------------------------------
Retrieving all Columns with an "Active" status
GET
https://rocketelev.azurewebsites.net/api/columns/get/status/active
-----------------------------------------------------------------
Retrieving all Columns with an "Inactive" status
GET
https://rocketelev.azurewebsites.net/api/columns/get/status/inactive
-----------------------------------------------------------------
Retrieving all Columns with an "Intervention" status
GET
https://rocketelev.azurewebsites.net/api/columns/get/status/intervention
-----------------------------------------------------------------
Retrieving all Columns with an "Others" status
GET
https://rocketelev.azurewebsites.net/api/columns/get/status/others
-----------------------------------------------------------------

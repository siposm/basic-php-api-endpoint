<?php

    // .htaccess file (if needed) should contain this line:
    // Header set Access-Control-Allow-Origin "*"

    header('Content-Type: application/json');

    $database = array (
        array (
            "name" => "John Doe",
            "age" => 35,
            "job" => "Full-stack web developer",
            "salary" => 4000
        ),
        array (
            "name" => "Claudia",
            "age" => 22,
            "job" => "Frontend web designer",
            "salary" => 2000
        ),
        array (
            "name" => "Steve",
            "age" => 40,
            "job" => "IT architect",
            "salary" => 5000
        ),
        array (
            "name" => "Peter",
            "age" => 30,
            "job" => "IT system administrator",
            "salary" => 2000
        ),array (
            "name" => "Kevin",
            "age" => 22,
            "job" => "Angular JS specialist",
            "salary" => 2700
        ),
        array (
            "name" => "Kate",
            "age" => 28,
            "job" => "Finance leader",
            "salary" => 6000
        ),
        array (
            "name" => "Paul",
            "age" => 45,
            "job" => "CEO & Founder",
            "salary" => 10000
        ),
        array (
            "name" => "Emma",
            "age" => 27,
            "job" => "Sales representative",
            "salary" => 3000
        ),
        array (
            "name" => "Sherlock",
            "age" => 40,
            "job" => "IT researcher",
            "salary" => 50000
        ),
        array (
            "name" => "Romana",
            "age" => 40,
            "job" => "Administrator",
            "salary" => 3660
        ),
        array (
            "name" => "Michele",
            "age" => 22,
            "job" => "IT architect",
            "salary" => 5000
        ),
        array (
            "name" => "Joseph",
            "age" => 27,
            "job" => "Sales representative",
            "salary" => 3000
        ),
        array (
            "name" => "Grant",
            "age" => 40,
            "job" => "IT researcher",
            "salary" => 50000
        ),
        array (
            "name" => "Thompson",
            "age" => 40,
            "job" => "Administrator",
            "salary" => 3660
        ),
        array (
            "name" => "Leon",
            "age" => 22,
            "job" => "IT architect",
            "salary" => 5000
        ),
        array (
            "name" => "Jill",
            "age" => 27,
            "job" => "Sales representative",
            "salary" => 3000
        ),
        array (
            "name" => "Wesker",
            "age" => 41,
            "job" => "IT researcher",
            "salary" => 56000
        ),
        array (
            "name" => "Dr. Birkin",
            "age" => 40,
            "job" => "Administrator",
            "salary" => 3660
        ),
        array (
            "name" => "William",
            "age" => 22,
            "job" => "IT architect",
            "salary" => 23000
        )
    );

    if(isset($_GET['age']))
    {
        $filter = array();
        for ($i=0; $i < count($database); $i++)
            if($database[$i]["age"] == $_GET['age'])
                array_push($filter, $database[$i]);

        echo json_encode($filter);
    }
    else
        echo json_encode($database);
?>
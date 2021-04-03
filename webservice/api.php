<?php

include 'koneksi.php';

$action = $_GET['action'];

$username = $connection->real_escape_string($_GET['username']);
$password = $connection->real_escape_string(md5($_GET['password']));

if ($action == null) {
    echo "Please enter your Action!";
} else {
    if ($action == "login") {
        $query = $connection->query("SELECT * FROM users WHERE username = '$username' and password ='$password'");
        $con = $query->num_rows;
        if ($con > 0) {
            echo "success";
        } else {
            echo "error";
        }
    } else {
        echo "Invalid Action!";
    }
}

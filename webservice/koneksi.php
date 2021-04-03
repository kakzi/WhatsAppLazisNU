<?php
$host = "localhost";
$user = "u6734273_apiwhatsappuser";
$password = "L;WP1G0jStWw";
$database = "u6734273_apiwhatsapp";

$connection = new mysqli($host, $user, $password, $database);
if ($connection->connect_errno) {
    printf("Connection Failed:", $connection->connect_error);
}

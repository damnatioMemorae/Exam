```php
//1. Find the sum of the digits of three-digit natural numbers.

<?php
$number = 345; // any three-digit number

$hundreds = intdiv($number, 100);
$tens = intdiv($number % 100, 10);
$units = $number % 10;

$sum = $hundreds + $tens + $units;

echo "Sum of digits: " . $sum;
?>

//2.Find the first and last digits of the number.

<?php
$number = 345;

// Last digit
$last = $number % 10;

// First digit
$first = $number;
while ($first >= 10) {
    $first = intdiv($first, 10);
}

echo "First digit: $first\n";
echo "Last digit: $last\n";
?>

//3. Find the second digit of the integer.

<?php
$number = 345;

// Second digit (tens place)
$second = intdiv($number % 100, 10);

echo "Second digit: $second";
?>

//4. Find the sum of the digit of the number.

<?php
$number = 345;
$sum = 0;

while ($number > 0) {
    $sum += $number % 10;  // get last digit
    $number = intdiv($number, 10); // remove last digit
}

echo "Sum of digits: $sum";
?>

//5. Given an array consisting of n integers, find the count of distinct elements in the array.

<?php
$array = [1, 2, 2, 3, 4, 4, 5];

$unique = array_unique($array);
$count = count($unique);

echo "Count of distinct elements: $count";
?>

//6. $string = "dffgdhfsdafsfdsgdgh" Write a function that takes a given length and creates a random string of that length, then converts each character into an array

<?php
function randomStringToArray($length) {
    $characters = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789';
    $randomString = '';

    for ($i = 0; $i < $length; $i++) {
        $randomString .= $characters[rand(0, strlen($characters) - 1)];
    }

    // Convert string to array
    $array = str_split($randomString);

    return $array;
}

// Example usage
$result = randomStringToArray(10);
print_r($result);
?>

//7. Shift the elements in the given array one step to the left ($a = [1,2,3];).

<?php
$a = [1, 2, 3];

$first = array_shift($a); // remove first element
$a[] = $first;            // add it to the end

print_r($a);
?>

//8. Shift the elements in the given array one step to the right ($a = [1,2,3];)

<?php
$a = [1, 2, 3];

$last = array_pop($a); // remove last element
array_unshift($a, $last); // add it to the beginning

print_r($a);
?>

//9. Find the maximum element and its count in the array.

<?php
$a = [1, 3, 5, 5, 2, 5, 3];

$max = max($a); // find maximum value
$count = 0;

foreach ($a as $value) {
    if ($value == $max) {
        $count++;
    }
}

echo "Maximum element: $max\n";
echo "Count: $count";
?>

//10. Find the unique elements." ($a = [2,3,1,4,5]; $b = [2,1,6,7,8] )

<?php
$a = [2, 3, 1, 4, 5];
$b = [2, 1, 6, 7, 8];

// Elements in $a but not in $b
$uniqueA = array_diff($a, $b);

// Elements in $b but not in $a
$uniqueB = array_diff($b, $a);

// Combine results
$result = array_merge($uniqueA, $uniqueB);

print_r($result);
?>

//11. Write a function that counts the number of words in the given string

<?php
function countWords($string) {
    // Remove extra spaces at the start/end
    $string = trim($string);

    if ($string === '') {
        return 0; // empty string has 0 words
    }

    // Split by spaces
    $words = preg_split('/\s+/', $string);

    return count($words);
}

// Example usage
$text = "This is an example string.";
echo "Number of words: " . countWords($text);
?>

//12. Find the index of the first and last whitespace characters in the given string

<?php
$string = "Hello world, how are you?";

// First whitespace
$firstSpace = strpos($string, ' ');

// Last whitespace
$lastSpace = strrpos($string, ' ');

echo "First whitespace index: $firstSpace\n";
echo "Last whitespace index: $lastSpace\n";
?>

//13. $a = 31233493; $b = 3; output: 4

<?php
$a = 31233493;
$b = 3;

// Convert number to string
$str = (string)$a;

// Count occurrences of $b
$count = substr_count($str, (string)$b);

echo $count; // Output: 4
?>

//14. If there are at least two same digits in the given number, return 'yes'. Otherwise, return 'no'.

<?php
function hasDuplicateDigits($number) {
    $digits = str_split((string)$number); // convert number to array of digits
    $counts = array_count_values($digits); // count occurrences of each digit

    foreach ($counts as $count) {
        if ($count >= 2) {
            return 'yes';
        }
    }

    return 'no';
}

// Example usage
$number = 31233493;
echo hasDuplicateDigits($number); // Output: yes

$number2 = 12345;
echo hasDuplicateDigits($number2); // Output: no
?>

//15. Write an HTML Form with checkboxes, and in PHP, print the selected value or values to the screen.

<!-- save as form.php -->
<!DOCTYPE html>
<html>
<head>
    <title>Checkbox Example</title>
</head>
<body>

<form method="post" action="">
    <p>Select your favorite fruits:</p>
    <input type="checkbox" name="fruits[]" value="Apple"> Apple<br>
    <input type="checkbox" name="fruits[]" value="Banana"> Banana<br>
    <input type="checkbox" name="fruits[]" value="Cherry"> Cherry<br>
    <input type="checkbox" name="fruits[]" value="Date"> Date<br>
    <input type="submit" name="submit" value="Submit">
</form>

<?php
if (isset($_POST['submit'])) {
    if (!empty($_POST['fruits'])) {
        echo "You selected: " . implode(", ", $_POST['fruits']);
    } else {
        echo "No fruits selected.";
    }
}
?>

</body>
</html>

//16. Write an HTML Form with select, and in PHP, print the selected value or values to the screen

<!-- save as select_form.php -->
<!DOCTYPE html>
<html>
<head>
    <title>Select Example</title>
</head>
<body>

<form method="post" action="">
    <p>Select your favorite fruits:</p>
    <select name="fruits[]" multiple>
        <option value="Apple">Apple</option>
        <option value="Banana">Banana</option>
        <option value="Cherry">Cherry</option>
        <option value="Date">Date</option>
    </select>
    <br><br>
    <input type="submit" name="submit" value="Submit">
</form>

<?php
if (isset($_POST['submit'])) {
    if (!empty($_POST['fruits'])) {
        echo "You selected: " . implode(", ", $_POST['fruits']);
    } else {
        echo "No fruits selected.";
    }
}
?>

</body>
</html>

//17. Write about is_file(), file_exists(), touch() functions with code examples.

<?php
$filename = "example.txt";

if (file_exists($filename)) {
    echo "$filename exists.";
} else {
    echo "$filename does not exist.";
}
?>

//18. Write about fopen(), fwrite(), fclose() functions with code examples.

<?php
$filename = "example.txt";

// Open file for writing
$file = fopen($filename, "w");

if ($file) {
    echo "$filename opened successfully.";
} else {
    echo "Failed to open $filename.";
}
?>

//19. Write about mkdir(), rmdir(), glob() functions with code examples.


<?php
$dir = "myfolder";

// Create a single directory
if (mkdir($dir)) {
    echo "Directory '$dir' created successfully.";
} else {
    echo "Failed to create directory '$dir'.";
}

// Create nested directories
$nestedDir = "parent/child";
mkdir($nestedDir, 0777, true); // true allows recursive creation
?>
```

```php
1. Find the sum of the digits of three-digit natural numbers.

<?php
$totalSum = 0;

for ($i = 100; $i <= 999; $i++) {
        $digits = str_split($i);
        foreach ($digits as $digit) {
                $totalSum += $digit;
        }
}

echo $totalSum;
?>

2. Find the first and last digits of the number.

<?php
$num = 12345;

$str = (string)$num;

$first = $str[0];
$last = $str[strlen($str) - 1];

echo "First digit: " . $first . "\n";
echo "Last digit: " . $last;
?>

3. Find the second digit of the integer.

<?php
$num = 12345;

$str = (string)$num;

if (strlen($str) >= 2) {
        echo "Second digit: " . $str[1];
} else {
        echo "No second digit";
}
?>

4. Find the sum of the digits of the number.

<?php
$num = 12345;

$digits = str_split((string)$num);
$sum = array_sum($digits);

echo "Sum of digits: " . $sum;
?>

5. Given an array consisting of n integers, find the count of distinct elements in the array.

<?php
$arr = [1, 2, 2, 3, 4, 4, 5];

$distinct = array_unique($arr);

echo "Count of distinct elements: " . count($distinct);
?>

6. $string = "dffgdhfsdafsfdsgdgh" Write a function that takes a given length and creates a random string of that length, then converts each character into an array.

<?php

function generateRandomStringArray($length)
{
        $characters = 'abcdefghijklmnopqrstuvwxyz';
        $result = '';

        for ($i = 0; $i < $length; $i++) {
                $index = random_int(0, strlen($characters) - 1);
                $result .= $characters[$index];
        }

        return str_split($result);
}

?>

7. Shift the elements in the given array one step to the left ($a = [1,2,3]; // output: [2,3,1]).

<?php
$a = [1, 2, 3];

// Take first element
$first = array_shift($a);

// Add it to the end
$a[] = $first;

print_r($a);
?>

8. Shift the elements in the given array one step to the right ($a = [1,2,3]; // output: [3,1,2]).

<?php
$a = [1, 2, 3];

// Get last element
$last = array_pop($a);

// Add it to the beginning
array_unshift($a, $last);

print_r($a);
?>

9. Find the maximum element and its count in the array.

<?php
$arr = [1, 5, 2, 5, 3, 5, 4];

// Find maximum element
$max = max($arr);

// Count how many times it appears
$count = 0;
foreach ($arr as $value) {
        if ($value == $max) {
                $count++;
        }
}

echo "Maximum element: " . $max . "\n";
echo "Count: " . $count;
?>

10. Find the unique elements ($a = [2,3,1,4,5]; $b = [2,1,6,7,8]).

<?php
$a = [2, 3, 1, 4, 5];
$b = [2, 1, 6, 7, 8];

// Elements only in $a
$uniqueA = array_diff($a, $b);

// Elements only in $b
$uniqueB = array_diff($b, $a);

// Merge both results
$result = array_merge($uniqueA, $uniqueB);

print_r($result);
?>

11. Write a function that counts the number of words in the given string.

<?php

function countWords($str)
{
        $words = str_word_count($str);
        return $words;
}

// Example
$text = "Hello world, this is PHP";
echo "Word count: " . countWords($text);

?>

12. Find the index of the first and last whitespace characters in the given string.

<?php
$str = "Hello world this is PHP";

// First whitespace
$first = strpos($str, " ");

// Last whitespace
$last = strrpos($str, " ");

echo "First whitespace index: " . $first . "\n";
echo "Last whitespace index: " . $last;
?>

13. $a = 31233493; $b = 3; output: 4

<?php
$a = 31233493;
$b = 3;

$count = substr_count((string)$a, (string)$b);

echo $count;
?>

14. If there are at least two same digits in the given number, return "yes". Otherwise, return "no".

<?php
$num = 12345;

$digits = str_split((string)$num);

if (count($digits) > count(array_unique($digits))) {
        echo "yes";
} else {
        echo "no";
}
?>

15. Write an HTML Form with checkboxes, and in PHP, print the selected value or values to the screen.

<!DOCTYPE html>
<html>

<body>

        <form method="post" action="">
                <h3>Select your favorite languages:</h3>

                <input type="checkbox" name="languages[]" value="PHP"> PHP<br>
                <input type="checkbox" name="languages[]" value="Java"> Java<br>
                <input type="checkbox" name="languages[]" value="C#"> C#<br>
                <input type="checkbox" name="languages[]" value="Python"> Python<br>

                <br>
                <input type="submit" name="submit" value="Submit">
        </form>

</body>

</html>

<?php
if (isset($_POST['submit'])) {
        if (!empty($_POST['languages'])) {
                echo "Selected values:<br>";

                foreach ($_POST['languages'] as $value) {
                        echo $value . "<br>";
                }
        } else {
                echo "No option selected";
        }
}
?>

16. Write an HTML Form with select, and in PHP, print the selected value or values to the screen.

Single Select Example
<!DOCTYPE html>
<html>

<body>

        <form method="post" action="">
                <h3>Select your favorite language:</h3>

                <select name="language">
                        <option value="PHP">PHP</option>
                        <option value="Java">Java</option>
                        <option value="C#">C#</option>
                        <option value="Python">Python</option>
                </select>

                <br><br>
                <input type="submit" name="submit" value="Submit">
        </form>

</body>

</html>

<?php
if (isset($_POST['submit'])) {
        if (!empty($_POST['language'])) {
                echo "Selected value: " . $_POST['language'];
        } else {
                echo "No option selected";
        }
}
?>

Multiple Select Example

<form method="post" action="">
        <h3>Select your favorite languages:</h3>

        <select name="languages[]" multiple>
                <option value="PHP">PHP</option>
                <option value="Java">Java</option>
                <option value="C#">C#</option>
                <option value="Python">Python</option>
        </select>

        <br><br>
        <input type="submit" name="submit" value="Submit">
</form>

<?php
if (isset($_POST['submit'])) {
        if (!empty($_POST['languages'])) {
                echo "Selected values:<br>";

                foreach ($_POST['languages'] as $value) {
                        echo $value . "<br>";
                }
        } else {
                echo "No option selected";
        }
}
?>

17. Write about is_file(), file_exists(), touch() functions with code examples.

<?php
$file = "demo.txt";

// Create file if it doesn't exist
if (!file_exists($file)) {
        touch($file);
        echo "File created<br>";
}

// Check if it's a file
if (is_file($file)) {
        echo "It is a valid file";
}
?>

18. Write about fopen(), fwrite(), fclose() functions with code examples.

<?php
$file = fopen("demo.txt", "w");

if ($file) {
        fwrite($file, "Hello World!\n");
        fwrite($file, "This is a second line.");

        fclose($file);

        echo "Data written successfully!";
} else {
        echo "Failed to open file";
}
?>

19. Write about mkdir(), rmdir(), glob() functions with code examples.

<?php
$dir = "testFolder";

// Create directory
if (!file_exists($dir)) {
        mkdir($dir);
        echo "Folder created<br>";
}

// Create some files inside
file_put_contents("$dir/file1.txt", "Hello");
file_put_contents("$dir/file2.txt", "World");

// List files using glob
$files = glob("$dir/*.txt");

echo "Files in folder:<br>";
foreach ($files as $file) {
        echo $file . "<br>";
}

// Remove files first (rmdir needs empty folder)
foreach ($files as $file) {
        unlink($file);
}

// Delete directory
rmdir($dir);
echo "<br>Folder deleted";
?>
```

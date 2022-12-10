
# Regular Expressions

With solving this problems, I practice working with RegEx.

## Problem:Extract Emails
Write a program to extract all email addresses from a given text. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format <user>@<host>, where: 

•	<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them.

o	Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "sofia-bulgaria", "12345".

o	Examples of invalid users: ''--123", ".....", "vokan_-", "_steve", ".info". 

•	<host> is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters and can have hyphens '-' between the letters.

o	Examples of hosts: "sofia.bg", "sofia-university.com", "intoprogramming.info", "mail.sofia.org". 

o	Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-". 

•	Examples of valid emails: info@sofia-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@sofia-university.software.academy. 

•	Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.

### Example:
#### input:
Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.
#### output:
s.miller@mit.edu
j.hopking@york.ac.uk

## Problem:Use Your Chains, Buddy
You are in Cherny Vit now and there are 12km to Anchova Bichkiya Hut.
 You need to get there by car. But there is so much snow that you need to use car chains. In order to put them on the wheels correctly, you need to read the manual. But it is encrypted…
As input you will receive an HTML document as a single string. 

You need to get the text from all the <p> tags and replace all characters which are not small letters and numbers with a space " ". After that you must decrypt the text – all letters from a to m are converted to letters from n to z (a  n; b  o; … m  z). The letters from n to z are converted to letters from a to m (n  a; o  b; … z  m).

 All multiple spaces should then be replaced by only one space.

For example, if we have "<div>Santa</div><p>znahny # grkg ()&^^^&12</p>" we extract "znahny # grkg ()&^^^&12".

 Every character that is not a small letter or a number is replaced with a space ("znahny grkg       12"). 
 
 
We convert each small letter as described above ("znahny grkg       12"  "manual text       12") and replace all multiple spaces with only one space ("manual text 12").

 Finally, we concatenate the decrypted text from all <p></p> tags (in this case, it's only one). And there you go – you have the manual ready to read!
### Example:
#### input:
<html><head><title></title></head><body><h1>Intro</h1><ul><li>Item01</li><li>Item02</li><li>Item03</li></ul><p>jura qevivat va jrg fyvccrel fabjl</p><div><button>Click me, baby!</button></div><p> pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx </p><span>This manual is false, do not trust it! The illuminati wrote it down to trick you!</span><p>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</p><p> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</p></body>

#### output:
when driving in wet slippery snowy conditions snow chains are absolutely essential for safe handling although snow chains may look intimidating the basic idea is really simple fit them over your tires drive forward slowly and tighten them up in cold wet conditions this is easier said than done but if you put on your tires

## Problem:Weather

You have to make a weather forecast about the weather depending on strings, which you receive from the console. Every string consists of data about the city, average temperature and weather type. You will receive strings until you receive the command “end”. 
Every valid weather forecast consists of:


•	Two Latin capital letters, which represent the code of the city

•	Immediately followed by a floating-point number, which will represent the average temperature. Numbers without a floating point are not considered valid.

•	Followed by the type of weather, which will consist of uppercase and lowercase Latin letters, starts immediately after the temperature and ends at the first occurrence of the sign ‘|’

If you receive input, which does not follow the rules above – ignore it.

If you receive a new temperature and/or type of weather for a city, which already exists – rewrite the previous values.

At the end, print the temperature and weather type for every city. Order the cities by average temperature in ascending order.

### Example

#### input:
invalidKA31,41|sunny|

validCA12,41Rainy|absad

gfASFasASPA31,21cloudy|asd

YA21,51sunny|

sadL21,41rainy|adas

end


#### output:

CA => 12,41 => Rainy

YA => 21,51 => sunny

PA => 31,21 => cloudy

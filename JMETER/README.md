# JMeter #

1) USE THE COMMAND LINE

You can execute JMeter test from the command line. It is as simple as

jmeter -n -t your_script.jmx

where
-n - tells JMeter to run in non-GUI mode
-t - specifies the path to source .jmx script to run

We often use these minimal options in combination with -l switch, which tells JMeter where to store test results. 
If a results file already exists, it will be appended. After the test execution you can open the resulting CSV 
file with any Listener, Excel, or any other analytics software.

-l test_result.csv

== >  jmeter -n -t your_script.jmx -l test_result.csv

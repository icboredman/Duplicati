#!/bin/sh
# script to test whether any workstation is connected,
# and if not - do shutdown.

numUsers=`netstat -atn | grep -c '192.168.178.199:1234'`

if [ $numUsers -ne 0 ]
then
   echo "At least one user is connected!"
   shutdown -c
else
   echo "Nobody's connected anymore!"
   shutdown -h +10
fi

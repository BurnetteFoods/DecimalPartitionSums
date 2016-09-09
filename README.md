# DecimalPartitionSums
Given a total and a set of key, amount pairs, finds the sets that can sum to the total

We want to find sets of the keys, whose values total to the given total

Call DecimalPartitionSums with one argument, a csv file

The first line should contain just a decimal total amount
Each subsequent line should contain a key, amount

DPS will look for sets of the keys whose amounts total to the total amount.

This will take way too long to run if your key set is too big, since their are 2^n sets possible for n lines of keys.

Example CSV:

  15887.46
  6346,1450.4
  6372,-1450.4
  6373,1495.56
  6376,726.33
  6383,706.78
  6389,1060.81
  6390,1048.54
  6406,698.39
  6424,1034.1
  6430,709.53
  6487,1069.99
  6508,956.68
  6510,955.84
  6572,1012.86
  6612,997.42
  6614,985.84
  6619,1000.51
  6628,864.64
  6700,88.78
  6723,-88.78
  10809,1378.92
  10828,6836.24
  10834,1419.62
  10852,528
  10868,5724.68
  10938,5597.17
  10984,6144.98
  10991,-6144.98
  10992,7406.91
  11026,-7406.91
  11027,7578.17
  11036,5424.4
  11044,6555.36
  11166,5326.99
  11208,6581.81
  11222,-6581.81
  11223,6915.54
  11224,-6915.54
  11225,6750.57

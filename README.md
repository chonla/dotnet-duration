# Chonla.Duration

.Net Framework Duration Parser that returns TimeSpan object.

## Features

* Parsing time duration and return TimeSpan object.
* Negative duration is supported.

## Installation

See https://www.nuget.org/packages/Chonla.Duration/ for detail.

## Supported duration

* ms - Milliseconds
* s - Seconds
* m - Minutes
* h - Hours
* d - Days

## Example

```
var dur = new Duration();
var timespan = dur.Parse("20ms");
```

## License

MIT: http://chonla.mit-license.org/
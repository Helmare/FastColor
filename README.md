# FastColor
As the name suggest, this project features fast color operations ideal for high speed image processing. This project goes great with [FastBitmap](http://github.com/hazdryx/FastBitmap) for high performance image manipulation on the CPU. The table below shows what operations are currently supported and for what color formats.

| Operation | Description                                 | Color Formats |
| --------- | ------------------------------------------- | ------------- |
| `explode` | Splits an `int` into it's color components. | `argb32`      |
| `implode` | Combines color components into an `int`.    | `argb32`      |
| `add`     | Adds two colors together                    | `argb32`      |
| `sub`     | Subtracts two colors from eachother         | `argb32`      |
| `mul`     | Multiplies two colors together              | `argb32`      |

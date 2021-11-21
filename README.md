# FastColor
As the name suggest, this project features fast color operations ideal for high speed image processing. This project goes great with [FastBitmap](http://github.com/hazdryx/FastBitmap) for high performance image manipulation on the CPU. The table below shows what operations are currently supported and for what color formats.

| Operation | Description                                  | Color Formats                            |
| --------- | -------------------------------------------- | ---------------------------------------- |
| `Explode` | Splits an `int` into it's color components.  | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Implode` | Combines color components into an `int`.     | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Reverse` | Flips argb components to bgra or vice versa. | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Add`     | Adds two colors together                     | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Sub`     | Subtracts two colors from eachother          | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Mul`     | Multiplies two colors together               | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |

*`rgb24` and `bgr24` colors are supported, but the alpha value is read as `0`*

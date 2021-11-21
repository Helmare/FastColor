# FastColor
As the name suggest, this project features fast color operations ideal for high speed image processing. 

[![nuget](https://img.shields.io/nuget/v/Hazdryx.FastColor.svg)](https://www.nuget.org/packages/Hazdryx.FastColor/)
![build](https://github.com/hazdryx/FastColor/actions/workflows/publish.yml/badge.svg)

This project goes great with [FastBitmap](http://github.com/hazdryx/FastBitmap) for high performance image manipulation on the CPU. The table below shows what operations are currently supported and for what color formats.

| Operation | Description                                  | Color Formats                            |
| --------- | -------------------------------------------- | ---------------------------------------- |
| `Explode` | Splits an `int` into it's color components.  | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Implode` | Combines color components into an `int`.     | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Reverse` | Flips argb components to bgra or vice versa. | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Add`     | Adds two colors together                     | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Sub`     | Subtracts two colors from eachother          | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |
| `Mul`     | Multiplies two colors together               | `argb32`, `bgra32`, `rgb24`\*, `bgr24`\* |

*`rgb24` and `bgr24` colors are supported, but the alpha value is read as `0`*

## Contribute
Want to help move this project forward? Consider contributing to the project. There are many different ways you can help out, even if you don't want to submit code changes.

### Use In Your Projects
The easiest way to contribute is to have this repo as a dependency in your projects. This contribution gives the project more recognition and likely to be seen by other developers, thereby growing the community.

### Submit Pull Requests
If you would like to make changes to the codebase or documentation, you can submit a pull request. Make sure to check out the [CONTRIBUTING.md](./CONTRIBUTING.md) for pull request requirements.

### Donate
If you don't want to submit a pull request or just want to support my work further, consider sending me a donation. Donations help me spend more time on open-source projects so they can be of the highest quality possible.

<a href="https://www.buymeacoffee.com/hazdryx" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-violet.png" alt="Buy Me A Coffee" style="height: 60px !important;width: 217px !important;" ></a>

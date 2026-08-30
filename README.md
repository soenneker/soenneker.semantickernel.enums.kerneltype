[![](https://img.shields.io/nuget/v/soenneker.semantickernel.enums.kerneltype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.semantickernel.enums.kerneltype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.semantickernel.enums.kerneltype/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.semantickernel.enums.kerneltype/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.semantickernel.enums.kerneltype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.semantickernel.enums.kerneltype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.semantickernel.enums.kerneltype/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.semantickernel.enums.kerneltype/actions/workflows/codeql.yml)

# Soenneker.SemanticKernel.Enums.KernelType

A source-generated string value type for classifying Semantic Kernel workloads.

## Installation

```bash
dotnet add package Soenneker.SemanticKernel.Enums.KernelType
```

## Values

- `KernelType.Chat`
- `KernelType.Completion`
- `KernelType.Image`
- `KernelType.Embedding`
- `KernelType.Audio`

Each underlying string value matches its member name, such as `"Chat"` and `"Embedding"`.

## Usage

```csharp
using Soenneker.SemanticKernel.Enums.KernelType;

KernelType type = KernelType.Chat;

if (type == KernelType.Chat)
{
    // Select chat-specific connector or execution behavior.
}
```

Parse untrusted input without throwing:

```csharp
if (!KernelType.TryFromValue(input, out KernelType type))
{
    return Results.BadRequest("Unsupported kernel type.");
}
```

Known values can also be retrieved with `FromValue`, `TryFromName`, and `FromName`. Name and value lookups are ordinal and case-sensitive.

The generated JSON converter reads and writes the underlying string:

```json
{
  "type": "Embedding"
}
```

Unknown JSON values fail deserialization. `KernelType` is descriptive metadata only; assigning a value does not register a Semantic Kernel connector or enforce which operations a kernel supports. The application or pool consuming it must select the corresponding implementation.

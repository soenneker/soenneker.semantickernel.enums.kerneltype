[![](https://img.shields.io/nuget/v/soenneker.semantickernel.enums.kerneltype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.semantickernel.enums.kerneltype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.semantickernel.enums.kerneltype/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.semantickernel.enums.kerneltype/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.semantickernel.enums.kerneltype.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.semantickernel.enums.kerneltype/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.semantickernel.enums.kerneltype/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.semantickernel.enums.kerneltype/actions/workflows/codeql.yml)

# Soenneker.SemanticKernel.Enums.KernelType

Represents the type of Semantic Kernel being requested or used. This helps differentiate between different AI workloads such as chat, completion, image generation, embeddings, and audio processing.

## Install

```bash
dotnet add package Soenneker.SemanticKernel.Enums.KernelType
```

## What you get

- `KernelType` — Represents the type of Semantic Kernel being requested or used. This helps differentiate between different AI workloads such as chat, completion, image generation, embeddings, and audio processing.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `KernelType.Chat` | A kernel used for chat-based interactions, such as multi-turn conversations with role-based message context (e.g., GPT-4, GPT-3.5-turbo). | A kernel used for chat-based interactions, such as multi-turn conversations with role-based message context (e.g., GPT-4, GPT-3.5-turbo). |
| `KernelType.Completion` | A kernel used for single-prompt text completion, typically non-conversational (e.g., text-davinci-003). | A kernel used for single-prompt text completion, typically non-conversational (e.g., text-davinci-003). |
| `KernelType.Image` | A kernel used for text-to-image generation models (e.g., DALL·E, Stable Diffusion). | A kernel used for text-to-image generation models (e.g., DALL·E, Stable Diffusion). |
| `KernelType.Embedding` | A kernel used for generating vector embeddings from text for similarity search, RAG, or classification tasks (e.g., text-embedding-3-small). | A kernel used for generating vector embeddings from text for similarity search, RAG, or classification tasks (e.g., text-embedding-3-small). |
| `KernelType.Audio` | A kernel used for audio-related tasks, such as speech-to-text transcription or text-to-speech synthesis (e.g., Whisper). | A kernel used for audio-related tasks, such as speech-to-text transcription or text-to-speech synthesis (e.g., Whisper). |

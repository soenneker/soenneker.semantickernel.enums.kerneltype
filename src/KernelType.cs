using Intellenum;

namespace Soenneker.SemanticKernel.Enums.KernelType;

/// <summary>
/// Represents the type of Semantic Kernel being requested or used. This helps differentiate between different AI workloads such as chat, completion, image generation, embeddings, and audio processing.
/// </summary>
[Intellenum<string>]
public partial class KernelType
{
    /// <summary>
    /// A kernel used for chat-based interactions, such as multi-turn conversations with role-based message context (e.g., GPT-4, GPT-3.5-turbo).
    /// </summary>
    public static readonly KernelType Chat = new(nameof(Chat));

    /// <summary>
    /// A kernel used for single-prompt text completion, typically non-conversational (e.g., text-davinci-003).
    /// </summary>
    public static readonly KernelType Completion = new(nameof(Completion));

    /// <summary>
    /// A kernel used for text-to-image generation models (e.g., DALL·E, Stable Diffusion).
    /// </summary>
    public static readonly KernelType Image = new(nameof(Image));

    /// <summary>
    /// A kernel used for generating vector embeddings from text for similarity search, RAG, or classification tasks (e.g., text-embedding-3-small).
    /// </summary>
    public static readonly KernelType Embedding = new(nameof(Embedding));

    /// <summary>
    /// A kernel used for audio-related tasks, such as speech-to-text transcription or text-to-speech synthesis (e.g., Whisper).
    /// </summary>
    public static readonly KernelType Audio = new(nameof(Audio));
}
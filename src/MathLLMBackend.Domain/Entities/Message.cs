using MathLLMBackend.Domain.Enums;

namespace MathLLMBackend.Domain.Entities;

public class Message
{
    public Message(Chat chat, string text, MessageType type)
    {
        Chat = chat;
        Text = text;
        MessageType = type;
        IsSystemPrompt = type == MessageType.System;
    }
    
    public Message(Chat chat, string text, MessageType type, bool isSystemPrompt)
    {
        Chat = chat;
        Text = text;
        MessageType = type;
        IsSystemPrompt = isSystemPrompt;
    }
    
    public Message() { }

    public Guid Id { get; set; }
    
    public Guid ChatId { get; set; }
    public Chat Chat { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public MessageType MessageType { get; set; }
    public bool IsSystemPrompt { get; set; }
}

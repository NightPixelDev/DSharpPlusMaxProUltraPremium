// This file is part of the DSharpPlus project.
//
// Copyright (c) 2015 Mike Santiago
// Copyright (c) 2016-2022 DSharpPlus Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using DSharpPlus.Entities;

namespace DSharpPlus.CommandsNext.Entities
{
    /// <summary>
    /// Represents a formatted help message.
    /// </summary>
    public struct CommandHelpMessage
    {
        /// <summary>
        /// Gets the contents of the help message.
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Gets the embed attached to the help message.
        /// </summary>
        public DiscordEmbed Embed { get; }

        /// <summary>
        /// Creates a new instance of a help message.
        /// </summary>
        /// <param name="content">Contents of the message.</param>
        /// <param name="embed">Embed to attach to the message.</param>
        public CommandHelpMessage(string content = null, DiscordEmbed embed = null)
        {
            this.Content = content;
            this.Embed = embed;
        }
    }
}

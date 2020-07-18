namespace System.Windows
{
    /// <summary>
    /// This property determines how text is trimmed when it overflows the edge of its
    /// containing box.
    /// </summary>
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    public enum TextTrimming
    {
        /// <summary>
        /// Default no trimming
        /// </summary>
        None,

        /// <summary>
        /// Text is trimmed at character boundary. Ellipsis is drawn in place of invisible part.
        /// </summary>
        CharacterEllipsis,

        /// <summary>
        /// Text is trimmed at word boundary. Ellipsis is drawn in place of invisible part.
        /// </summary>
        WordEllipsis,
    }
}
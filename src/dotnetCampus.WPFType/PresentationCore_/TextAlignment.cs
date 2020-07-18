namespace System.Windows
{
    /// <summary>
    /// This property describes how content of a block is aligned.
    /// </summary>
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    public enum TextAlignment
    {
        /// <summary>
        /// In horizontal inline progression, the text is aligned on the left.
        /// </summary>
        Left,

        /// <summary>
        /// In horizontal inline progression, the text is aligned on the right.
        /// </summary>
        Right,

        /// <summary>
        /// The text is center aligned.
        /// </summary>
        Center,

        /// <summary>
        /// The text is justified.
        /// </summary>
        Justify,
    }
}
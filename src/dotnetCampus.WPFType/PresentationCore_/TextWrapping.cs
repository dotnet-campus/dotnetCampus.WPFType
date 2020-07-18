namespace System.Windows
{
    /// <summary>
    /// This property controls whether or not text wraps when it reaches the edge 
    /// of its containing box 
    /// </summary>
    [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
    public enum TextWrapping
    {
        /// <summary>
        /// Line-breaking occurs if the line overflows the available block width.
        /// However, a line may overflow the block width if the line breaking algorithm
        /// cannot determine a break opportunity, as in the case of a very long word.
        /// </summary>
        WrapWithOverflow,

        /// <summary>
        /// No line wrapping is performed. In the case when lines are longer than the 
        /// available block width, the overflow will be treated in accordance with the 
        /// 'overflow' property specified in the element.
        /// </summary>
        NoWrap,

        /// <summary>
        /// Line-breaking occurs if the line overflow the available block width, even 
        /// if the standard line breaking algorithm cannot determine any opportunity. 
        /// For example, this deals with the situation of very long words constrained in 
        /// a fixed-width container with no scrolling allowed.
        /// </summary>
        Wrap,
    }
}
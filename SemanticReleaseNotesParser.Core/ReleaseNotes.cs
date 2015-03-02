using DotLiquid;
using System.Collections.Generic;
using System.Text;

namespace SemanticReleaseNotesParser.Core
{
    /// <summary>
    /// Release notes
    /// </summary>
    public sealed class ReleaseNotes : Drop
    {
        /// <summary>
        /// Summary of the release notes
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Sections of the release notes
        /// </summary>
        public List<Section> Sections { get; set; }

        /// <summary>
        /// Items of the release notes
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Instantiates a new ReleaseNotes
        /// </summary>
        public ReleaseNotes()
        {
            Sections = new List<Section>();
            Items = new List<Item>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Summary);

            foreach (var item in Items)
            {
                sb.AppendLine("- " + item);
            }

            foreach (var section in Sections)
            {
                sb.AppendLine("* " + section);
            }

            return sb.ToString();
        }
    }
}

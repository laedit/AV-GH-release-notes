using DotLiquid;
using System.Collections.Generic;
using System.Text;

namespace SemanticReleaseNotesParser.Core
{
    /// <summary>
    /// Sections of a release notes
    /// </summary>
    public sealed class Section : Drop
    {
        /// <summary>
        /// Name of the section
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Summary of the section
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Items composing the section
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Icon of the section
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Instantiates a new Section
        /// </summary>
        public Section()
        {
            Items = new List<Item>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Name);

            sb.AppendLine(Summary);

            foreach (var item in Items)
            {
                sb.AppendLine("- " + item);
            }

            return sb.ToString();
        }
    }
}
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ContentItem : TeaModel {
        /// <summary>
        /// <para>The coordinates of the text are in list format.</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public List<ContentItemExtInfo> ExtInfo { get; set; }
        public class ContentItemExtInfo : TeaModel {
            /// <summary>
            /// <para>Enumeration values for page alignment options: center, left, and right.</para>
            /// 
            /// <b>Example:</b>
            /// <para>center</para>
            /// </summary>
            [NameInMap("alignment")]
            [Validation(Required=false)]
            public string Alignment { get; set; }

            /// <summary>
            /// <para>The index of the layout in the text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>Hierarchy of the layout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            /// <summary>
            /// <para>Page numbers of the layout, which may include multiple page numbers.</para>
            /// </summary>
            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public List<long?> PageNum { get; set; }

            /// <summary>
            /// <para>Position information of the layout, in list format.</para>
            /// </summary>
            [NameInMap("pos")]
            [Validation(Required=false)]
            public List<ContentItemExtInfoPos> Pos { get; set; }
            public class ContentItemExtInfoPos : TeaModel {
                /// <summary>
                /// <para>X coordinate of the layout.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("x")]
                [Validation(Required=false)]
                public long? X { get; set; }

                /// <summary>
                /// <para>Y coordinate of the layout.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("y")]
                [Validation(Required=false)]
                public long? Y { get; set; }

            }

            /// <summary>
            /// <para>Enumeration values for the layout subtypes: picture, para, none</para>
            /// 
            /// <b>Example:</b>
            /// <para>picture</para>
            /// </summary>
            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <para>text</para>
            /// 
            /// <b>Example:</b>
            /// <para>content</para>
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>Enumeration values for the layout types: table, figure, text, and none.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Unique layout ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88c712db271443dd4e3697cb9b5dab3a</para>
            /// </summary>
            [NameInMap("uniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

        }

        /// <summary>
        /// <para>Recall confidence</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.45</para>
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public double? Score { get; set; }

        /// <summary>
        /// <para>Recall text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>content</para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>Text sources: img, table, para.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

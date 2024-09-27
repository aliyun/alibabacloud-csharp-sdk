// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ContentItem : TeaModel {
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public List<ContentItemExtInfo> ExtInfo { get; set; }
        public class ContentItemExtInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>center</para>
            /// </summary>
            [NameInMap("alignment")]
            [Validation(Required=false)]
            public string Alignment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public List<long?> PageNum { get; set; }

            [NameInMap("pos")]
            [Validation(Required=false)]
            public List<ContentItemExtInfoPos> Pos { get; set; }
            public class ContentItemExtInfoPos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("x")]
                [Validation(Required=false)]
                public long? X { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("y")]
                [Validation(Required=false)]
                public long? Y { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>picture</para>
            /// </summary>
            [NameInMap("subType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>版面内容</para>
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>table</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>88c712db271443dd4e3697cb9b5dab3a</para>
            /// </summary>
            [NameInMap("uniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.45</para>
        /// </summary>
        [NameInMap("score")]
        [Validation(Required=false)]
        public double? Score { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>img</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

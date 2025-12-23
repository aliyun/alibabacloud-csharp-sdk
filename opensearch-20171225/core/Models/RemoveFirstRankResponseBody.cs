// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class RemoveFirstRankResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E676FAB6-A0AC-64D9-F9D7-D0D33C930CFF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the rough sort expression.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public RemoveFirstRankResponseBodyResult Result { get; set; }
        public class RemoveFirstRankResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Specifies whether to set the fine sort expression as the default sort expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The information about the expression.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<RemoveFirstRankResponseBodyResultMeta> Meta { get; set; }
            public class RemoveFirstRankResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <para>The parameters that are used by a function in the expression. For more information, see Rough sort functions.<a href="~~170007~~"></a></para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("arg")]
                [Validation(Required=false)]
                public string Arg { get; set; }

                /// <summary>
                /// <para>The attribute, which refers to the scoring feature or search field, For more information about supported feature functions, see Rough sort functions.<a href="~~170007~~"></a></para>
                /// 
                /// <b>Example:</b>
                /// <para>static_bm25()</para>
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The weight. Valid values: -100000 to 100000. The value cannot be 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public float? Weight { get; set; }

            }

            /// <summary>
            /// <para>Parameter</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}

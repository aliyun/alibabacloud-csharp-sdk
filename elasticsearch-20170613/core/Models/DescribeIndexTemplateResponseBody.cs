// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeIndexTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>25DB38F8-82E4-4D16-82BB-FF077C7F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeIndexTemplateResponseBodyResult Result { get; set; }
        public class DescribeIndexTemplateResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("dataStream")]
            [Validation(Required=false)]
            public bool? DataStream { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cube_default_ilm_policy</para>
            /// </summary>
            [NameInMap("ilmPolicy")]
            [Validation(Required=false)]
            public string IlmPolicy { get; set; }

            [NameInMap("indexPatterns")]
            [Validation(Required=false)]
            public List<string> IndexPatterns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>data-stream-default</para>
            /// </summary>
            [NameInMap("indexTemplate")]
            [Validation(Required=false)]
            public string IndexTemplate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("template")]
            [Validation(Required=false)]
            public DescribeIndexTemplateResponseBodyResultTemplate Template { get; set; }
            public class DescribeIndexTemplateResponseBodyResultTemplate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;mydata\&quot;:{}}</para>
                /// </summary>
                [NameInMap("aliases")]
                [Validation(Required=false)]
                public string Aliases { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;properties\&quot;:{\&quot;created_at\&quot;:{\&quot;format\&quot;:\&quot;EEE MMM dd HH:mm:ss Z yyyy\&quot;,\&quot;type\&quot;:\&quot;date\&quot;},\&quot;host_name\&quot;:{\&quot;type\&quot;:\&quot;keyword\&quot;}}}</para>
                /// </summary>
                [NameInMap("mappings")]
                [Validation(Required=false)]
                public string Mappings { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;index.refresh_interval\&quot;:\&quot;1s\&quot;}</para>
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

            }

        }

    }

}

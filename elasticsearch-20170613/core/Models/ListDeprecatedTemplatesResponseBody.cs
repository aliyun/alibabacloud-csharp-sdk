// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDeprecatedTemplatesResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDeprecatedTemplatesResponseBodyHeaders Headers { get; set; }
        public class ListDeprecatedTemplatesResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public long? XTotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC47D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDeprecatedTemplatesResponseBodyResult> Result { get; set; }
        public class ListDeprecatedTemplatesResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("dataStream")]
            [Validation(Required=false)]
            public bool? DataStream { get; set; }

            [NameInMap("indexPatterns")]
            [Validation(Required=false)]
            public List<string> IndexPatterns { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>openstore-index-template</para>
            /// </summary>
            [NameInMap("indexTemplate")]
            [Validation(Required=false)]
            public string IndexTemplate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            [NameInMap("template")]
            [Validation(Required=false)]
            public ListDeprecatedTemplatesResponseBodyResultTemplate Template { get; set; }
            public class ListDeprecatedTemplatesResponseBodyResultTemplate : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;{}&quot;</para>
                /// </summary>
                [NameInMap("aliases")]
                [Validation(Required=false)]
                public string Aliases { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;properties\&quot;:{\&quot;created_at\&quot;:{\&quot;format\&quot;:\&quot;EEE MMM dd HH:mm:ss Z yyyy\&quot;,\&quot;type\&quot;:\&quot;date\&quot;},\&quot;host_name\&quot;:{\&quot;type\&quot;:\&quot;keyword\&quot;}}}&quot;</para>
                /// </summary>
                [NameInMap("mappings")]
                [Validation(Required=false)]
                public string Mappings { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;index.number_of_shards\&quot;:\&quot;1\&quot;}&quot;</para>
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>70000</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

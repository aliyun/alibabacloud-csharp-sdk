// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListIndexTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The index template list information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListIndexTemplatesResponseBodyResult> Result { get; set; }
        public class ListIndexTemplatesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the data stream is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enabled.</para>
            /// </description></item>
            /// <item><description><para>false (default): not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("dataStream")]
            [Validation(Required=false)]
            public bool? DataStream { get; set; }

            /// <summary>
            /// <para>The index lifecycle policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_ilm_policy</para>
            /// </summary>
            [NameInMap("ilmPolicy")]
            [Validation(Required=false)]
            public string IlmPolicy { get; set; }

            /// <summary>
            /// <para>The index pattern information.</para>
            /// </summary>
            [NameInMap("indexPatterns")]
            [Validation(Required=false)]
            public List<string> IndexPatterns { get; set; }

            /// <summary>
            /// <para>The index template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-template</para>
            /// </summary>
            [NameInMap("indexTemplate")]
            [Validation(Required=false)]
            public string IndexTemplate { get; set; }

            /// <summary>
            /// <para>The index template priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The component template.</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public ListIndexTemplatesResponseBodyResultTemplate Template { get; set; }
            public class ListIndexTemplatesResponseBodyResultTemplate : TeaModel {
                /// <summary>
                /// <para>The aliases configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;index.number_of_shards\&quot;:\&quot;1\&quot;}</para>
                /// </summary>
                [NameInMap("aliases")]
                [Validation(Required=false)]
                public string Aliases { get; set; }

                /// <summary>
                /// <para>The mappings configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;properties\&quot;:{\&quot;created_at\&quot;:{\&quot;format\&quot;:\&quot;EEE MMM dd HH:mm:ss Z yyyy\&quot;,\&quot;type\&quot;:\&quot;date\&quot;},\&quot;host_name\&quot;:{\&quot;type\&quot;:\&quot;keyword\&quot;}}}</para>
                /// </summary>
                [NameInMap("mappings")]
                [Validation(Required=false)]
                public string Mappings { get; set; }

                /// <summary>
                /// <para>The settings configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;mydata\&quot;:{}}</para>
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

            }

        }

    }

}

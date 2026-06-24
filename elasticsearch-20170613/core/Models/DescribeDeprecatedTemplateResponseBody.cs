// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeDeprecatedTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC47D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDeprecatedTemplateResponseBodyResult Result { get; set; }
        public class DescribeDeprecatedTemplateResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether automatic creation of a data stream is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Automatic creation of a data stream is enabled.</description></item>
            /// <item><description>false: Automatic creation of a data stream is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("dataStream")]
            [Validation(Required=false)]
            public bool? DataStream { get; set; }

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
            /// <para>openstore-index-template</para>
            /// </summary>
            [NameInMap("indexTemplate")]
            [Validation(Required=false)]
            public string IndexTemplate { get; set; }

            /// <summary>
            /// <para>The priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            /// <summary>
            /// <para>The index template configuration information.</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public DescribeDeprecatedTemplateResponseBodyResultTemplate Template { get; set; }
            public class DescribeDeprecatedTemplateResponseBodyResultTemplate : TeaModel {
                /// <summary>
                /// <para>The alias configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{}&quot;</para>
                /// </summary>
                [NameInMap("aliases")]
                [Validation(Required=false)]
                public string Aliases { get; set; }

                /// <summary>
                /// <para>The mappings configuration of the index template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;properties\&quot;:{\&quot;created_at\&quot;:{\&quot;format\&quot;:\&quot;EEE MMM dd HH:mm:ss Z yyyy\&quot;,\&quot;type\&quot;:\&quot;date\&quot;},\&quot;host_name\&quot;:{\&quot;type\&quot;:\&quot;keyword\&quot;}}}&quot;</para>
                /// </summary>
                [NameInMap("mappings")]
                [Validation(Required=false)]
                public string Mappings { get; set; }

                /// <summary>
                /// <para>The settings configuration of the index template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;{\&quot;index.number_of_shards\&quot;:\&quot;1\&quot;}&quot;</para>
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

            }

            /// <summary>
            /// <para>The version of the index template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70000</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}

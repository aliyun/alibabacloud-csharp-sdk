// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RecommendTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66B060CF-7381-49C7-9B89-7757927FDA16</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<RecommendTemplatesResponseBodyResult> Result { get; set; }
        public class RecommendTemplatesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The template configuration content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\n\t\&quot;persistent\&quot;: {\n\t\t\&quot;search\&quot;: {\n\t\t\t\&quot;max_buckets\&quot;: \&quot;10000\&quot;\n\t\t}\n\t}\n}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The template name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>staticSettings: cluster static configuration</description></item>
            /// <item><description>dynamicSettings: cluster dynamic configuration</description></item>
            /// <item><description>indexTemplate: index template configuration</description></item>
            /// <item><description>ilmPolicy: index lifecycle configuration</description></item>
            /// </list>
            /// <remarks>
            /// <para>Advanced Edition instances of version 6.7.0 or later support enabling the index lifecycle template.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dynamicSettings</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

    }

}

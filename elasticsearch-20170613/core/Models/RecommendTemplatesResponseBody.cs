// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class RecommendTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>66B060CF-7381-49C7-9B89-7757927FDA16</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<RecommendTemplatesResponseBodyResult> Result { get; set; }
        public class RecommendTemplatesResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\n\t\&quot;persistent\&quot;: {\n\t\t\&quot;search\&quot;: {\n\t\t\t\&quot;max_buckets\&quot;: \&quot;10000\&quot;\n\t\t}\n\t}\n}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// </list>
            /// <para>**</para>
            /// <hr>
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

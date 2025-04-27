// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyResult> Result { get; set; }
        public class DescribeTemplatesResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{\n\t\&quot;persistent\&quot;:{\n\t\t\&quot;search\&quot;:{\n\t\t\t\&quot;max_buckets\&quot;:\&quot;10000\&quot;\n\t\t}\n\t}\n}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dynamicSettings</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

    }

}

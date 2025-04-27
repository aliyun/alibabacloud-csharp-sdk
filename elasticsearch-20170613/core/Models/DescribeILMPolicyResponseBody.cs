// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeILMPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FF44681E-FD41-4FDE-B8DF-295DCDD6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeILMPolicyResponseBodyResult Result { get; set; }
        public class DescribeILMPolicyResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ilm-history-ilm-policy</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;cold&quot;:{&quot;minAge&quot;:&quot;30d&quot;,&quot;actions&quot;:{&quot;allocate&quot;:{&quot;numberOfReplicas&quot;:1,&quot;require&quot;:{&quot;boxType&quot;:&quot;warm&quot;}},&quot;setPriority&quot;:{&quot;priority&quot;:100}}},&quot;hot&quot;:{&quot;minAge&quot;:&quot;0s&quot;,&quot;actions&quot;:{&quot;rollover&quot;:{&quot;maxAge&quot;:&quot;30d&quot;,&quot;maxDocs&quot;:10000,&quot;maxSize&quot;:&quot;50gb&quot;},&quot;setPriority&quot;:{&quot;priority&quot;:1000}}},&quot;delete&quot;:{&quot;minAge&quot;:&quot;30d&quot;,&quot;actions&quot;:{&quot;delete&quot;:{}}}}</para>
            /// </summary>
            [NameInMap("phases")]
            [Validation(Required=false)]
            public Dictionary<string, object> Phases { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListILMPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListILMPoliciesResponseBodyResult> Result { get; set; }
        public class ListILMPoliciesResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>policy-1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;hot&quot;:{&quot;minAge&quot;:&quot;0ms&quot;,&quot;actions&quot;:{&quot;rollover&quot;:{&quot;maxSize&quot;:&quot;50gb&quot;,&quot;maxAge&quot;:&quot;30d&quot;},&quot;setPriority&quot;:{&quot;priority&quot;:100}}},&quot;delete&quot;:{&quot;minAge&quot;:&quot;3d&quot;,&quot;actions&quot;:{&quot;delete&quot;:{}}}}</para>
            /// </summary>
            [NameInMap("phases")]
            [Validation(Required=false)]
            public Dictionary<string, object> Phases { get; set; }

        }

    }

}

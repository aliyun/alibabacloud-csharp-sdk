// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AddContextsResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of objects containing the results of the write operation.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<AddContextsResponseBodyResults> Results { get; set; }
        public class AddContextsResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The ID of the written record or event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>897294a7-67a4-4f60-976c-e136edc5f97e</para>
            /// </summary>
            [NameInMap("contextId")]
            [Validation(Required=false)]
            public string ContextId { get; set; }

            /// <summary>
            /// <para>The write status. Can be &quot;accepted&quot;, &quot;queued&quot;, or &quot;created&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>accepted</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AddContextsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("results")]
        [Validation(Required=false)]
        public List<AddContextsResponseBodyResults> Results { get; set; }
        public class AddContextsResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>897294a7-67a4-4f60-976c-e136edc5f97e</para>
            /// </summary>
            [NameInMap("contextId")]
            [Validation(Required=false)]
            public string ContextId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>accepted</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}

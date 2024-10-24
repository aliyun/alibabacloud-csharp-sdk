// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class QuerySessionInfoResponseBody : TeaModel {
        [NameInMap("queryResourceInfoList")]
        [Validation(Required=false)]
        public List<QuerySessionInfoResponseBodyQueryResourceInfoList> QueryResourceInfoList { get; set; }
        public class QuerySessionInfoResponseBodyQueryResourceInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>a169e9ec18404edc9972afd80866dc97</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FREE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4D902811-B75C-5D1B-8882-D515F8E2F977</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

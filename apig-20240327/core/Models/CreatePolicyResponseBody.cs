// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreatePolicyResponseBodyData Data { get; set; }
        public class CreatePolicyResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>p-cq7l5s5lhtgi6qasr***</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E7406754***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

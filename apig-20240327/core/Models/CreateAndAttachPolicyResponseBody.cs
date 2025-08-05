// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAndAttachPolicyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateAndAttachPolicyResponseBodyData Data { get; set; }
        public class CreateAndAttachPolicyResponseBodyData : TeaModel {
            [NameInMap("attachment")]
            [Validation(Required=false)]
            public Attachment Attachment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-cq7l5s5lhtgi6qasrdc0</para>
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
        /// <b>Example:</b>
        /// <para>585657D2-1C20-5B8A-AF17-D727C6490BE4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

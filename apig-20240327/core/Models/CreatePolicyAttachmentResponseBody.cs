// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePolicyAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreatePolicyAttachmentResponseBodyData Data { get; set; }
        public class CreatePolicyAttachmentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pr-cqooju5lhtgquuj6***</para>
            /// </summary>
            [NameInMap("policyAttachmentId")]
            [Validation(Required=false)]
            public string PolicyAttachmentId { get; set; }

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
        /// <para>585657D2-1C20-5B8A-AF17-D727C64***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

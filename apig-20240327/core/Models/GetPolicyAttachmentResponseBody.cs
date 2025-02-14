// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetPolicyAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPolicyAttachmentResponseBodyData Data { get; set; }
        public class GetPolicyAttachmentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>op-csbkd9llhtgqhqua***</para>
            /// </summary>
            [NameInMap("attachResourceId")]
            [Validation(Required=false)]
            public string AttachResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Operation</para>
            /// </summary>
            [NameInMap("attachResourceType")]
            [Validation(Required=false)]
            public string AttachResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;unitNum&quot;:1,&quot;timeUnit&quot;:&quot;s&quot;,&quot;enable&quot;:true}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>env-cq7l5s5lhtgi6qa***</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-cq2vundlhtg***</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pr-cqoojualhtgquuj***</para>
            /// </summary>
            [NameInMap("policyAttachmentId")]
            [Validation(Required=false)]
            public string PolicyAttachmentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p-cq7l5s5bblhtgi6qas***</para>
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
        /// <para>2C3B9A12-3868-5EB9-fBEA-F99E03DD1***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

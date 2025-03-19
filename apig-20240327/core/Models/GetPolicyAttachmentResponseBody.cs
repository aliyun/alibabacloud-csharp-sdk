// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetPolicyAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPolicyAttachmentResponseBodyData Data { get; set; }
        public class GetPolicyAttachmentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Attached Resource ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>op-csbkd9llhtgqhqua***</para>
            /// </summary>
            [NameInMap("attachResourceId")]
            [Validation(Required=false)]
            public string AttachResourceId { get; set; }

            /// <summary>
            /// <para>Attached resource type, HttpApi, GatewayRoute, Operation, GatewayService, GatewayServicePort, Gateway, Domain</para>
            /// 
            /// <b>Example:</b>
            /// <para>Operation</para>
            /// </summary>
            [NameInMap("attachResourceType")]
            [Validation(Required=false)]
            public string AttachResourceType { get; set; }

            /// <summary>
            /// <para>Policy attachment configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;unitNum&quot;:1,&quot;timeUnit&quot;:&quot;s&quot;,&quot;enable&quot;:true}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>Environment ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-cq7l5s5lhtgi6qa***</para>
            /// </summary>
            [NameInMap("environmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>Gateway Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-cq2vundlhtg***</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>Policy Attachment ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>pr-cqoojualhtgquuj***</para>
            /// </summary>
            [NameInMap("policyAttachmentId")]
            [Validation(Required=false)]
            public string PolicyAttachmentId { get; set; }

            /// <summary>
            /// <para>Policy ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>p-cq7l5s5bblhtgi6qas***</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

        }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C3B9A12-3868-5EB9-fBEA-F99E03DD1***</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

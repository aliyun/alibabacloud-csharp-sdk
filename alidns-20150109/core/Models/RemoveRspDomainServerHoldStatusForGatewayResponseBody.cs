// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class RemoveRspDomainServerHoldStatusForGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial. This field appears only when Resource Access Management (RAM) authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public RemoveRspDomainServerHoldStatusForGatewayResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class RemoveRspDomainServerHoldStatusForGatewayResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RemoveRspDomainServerHoldStatusForGateway</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authorized entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the owner of the authorized entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10469733312XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The identity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The complete diagnostic information after encryption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaNIARXXXXUQwNjE0LUQzN0XXXXVEQy1BQzExLTMzXXXXNTkxRjk1Ng==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The reason why authorization failed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ExplicitDeny: Access is explicitly denied.</para>
            /// </description></item>
            /// <item><description><para>ImplicitDeny: Access is implicitly denied.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RemoveRspDomainServerHoldStatusForGatewayResponseBodyData Data { get; set; }
        public class RemoveRspDomainServerHoldStatusForGatewayResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The domain\&quot;s serverHold status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("ServerHoldStatus")]
            [Validation(Required=false)]
            public string ServerHoldStatus { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether you can retry the request if it fails. Valid values: <c>true</c> (retry allowed) and <c>false</c> (retry not allowed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RecoverableError")]
        [Validation(Required=false)]
        public bool? RecoverableError { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0629502C-6224-5DC9-A8ED-2ED73A2E3931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Valid values: <c>true</c> (succeeded) and <c>false</c> (failed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

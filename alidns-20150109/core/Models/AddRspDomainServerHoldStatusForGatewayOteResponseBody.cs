// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddRspDomainServerHoldStatusForGatewayOteResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed access-denied information. This field appears only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public AddRspDomainServerHoldStatusForGatewayOteResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class AddRspDomainServerHoldStatusForGatewayOteResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>Unauthorized operation attempted</para>
            /// 
            /// <b>Example:</b>
            /// <para>AddRspDomainServerHoldStatusForGatewayOte</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>Display name of the authenticated entity</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>Owner ID of the authenticated entity</para>
            /// 
            /// <b>Example:</b>
            /// <para>10469733312XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>Identity type</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>Encrypted diagnostic message</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQFohtp4aIbaeEXXXXQxNjFDLUIzMzgtNTXXXX05NkFCLUI2RkY5XXXXzAzQQ==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>Reason for authentication failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ExplicitDeny: explicit deny</para>
            /// </description></item>
            /// <item><description><para>ImplicitDeny: implicit deny</para>
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
            /// <para>Policy type</para>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>List of returned data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddRspDomainServerHoldStatusForGatewayOteResponseBodyData Data { get; set; }
        public class AddRspDomainServerHoldStatusForGatewayOteResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Domain name</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether you can retry the request. <c>true</c>: retry allowed. <c>false</c>: retry not allowed</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RecoverableError")]
        [Validation(Required=false)]
        public bool? RecoverableError { get; set; }

        /// <summary>
        /// <para>Unique request identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>0629502C-6224-5DC9-A8ED-2ED73A2E3931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. <c>true</c>: succeeded. <c>false</c>: failed</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

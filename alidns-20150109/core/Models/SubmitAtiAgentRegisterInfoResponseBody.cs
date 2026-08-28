// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SubmitAtiAgentRegisterInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public SubmitAtiAgentRegisterInfoResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class SubmitAtiAgentRegisterInfoResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AddRspDomainServerHoldStatusForGateway</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authorization principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authorization principal.</para>
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
            /// <para>The encrypted complete diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaNIARXXXXUQwNjE0LUQzN0XXXXVEQy1BQzExLTMzXXXXNTkxRjk1Ng==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The reason for the authentication failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ExplicitDeny: explicit deny.</description></item>
            /// <item><description>ImplicitDeny: implicit deny.</description></item>
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
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Agent status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Draft: The Agent registration form is being filled in and has not been formally submitted. In the Draft state, only modification and detail viewing operations are supported. Other operations are not supported.</description></item>
        /// <item><description>Private CA Pending Issuance: The Agent registration has been formally submitted. Alibaba Cloud has completed the ACME DNS-01 pre-check and submitted the registration information and generated DNS records to CNNIC. The system is waiting for CNNIC to approve and issue the Private CA and complete TL sealing.</description></item>
        /// <item><description>DNS Pending Verification: CNNIC has approved the request, issued the Private CA certificate, and completed TL sealing, but the DNS records of the user have not been verified. The user needs to add the corresponding DNS records in domain name resolution and complete verification.</description></item>
        /// <item><description>Active: All processes are complete. The Private CA certificate has been issued, TL has been sealed, and DNS records have been verified. The Agent is activated and can be discovered and trusted across the network.</description></item>
        /// <item><description>Expired: The Agent identity certificate has expired, and the user did not complete certificate renewal within the validity period.</description></item>
        /// <item><description>Revoked: The Agent certificate has been revoked, DNS records have been cleaned up, and the Agent cannot be discovered or trusted. It cannot be restored to the Active state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Private CA 待签发</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public bool? Status { get; set; }

    }

}

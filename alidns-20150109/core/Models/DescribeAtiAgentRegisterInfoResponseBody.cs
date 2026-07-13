// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeAtiAgentRegisterInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeAtiAgentRegisterInfoResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeAtiAgentRegisterInfoResponseBodyAccessDeniedDetail : TeaModel {
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
            /// <para>1046973331XXXX</para>
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
            /// <para>AQFohtp4aIbaeEXXXXQxNjFDLUIzMzgtNTXXXX05NkFCLUI2RkY5XXXXzAzQQ==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The cause of the authentication failure. Valid values:</para>
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
        /// <para>The description of the Agent capabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>支付服务</para>
        /// </summary>
        [NameInMap("AgentDescription")]
        [Validation(Required=false)]
        public string AgentDescription { get; set; }

        /// <summary>
        /// <para>The display name of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试Agent</para>
        /// </summary>
        [NameInMap("AgentDisplayName")]
        [Validation(Required=false)]
        public string AgentDisplayName { get; set; }

        /// <summary>
        /// <para>The endpoint domain name through which the Agent provides services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("AgentHost")]
        [Validation(Required=false)]
        public string AgentHost { get; set; }

        /// <summary>
        /// <para>The Agent ID, which is uniformly assigned by CNNIC after real-name verification. The AgentId serves as the unique identifier that binds the Agent to the verified registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019f3672-9705-7a7a-88fd-9a6a211aa5f2</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The Agent registration ID. This ID is automatically generated by the Alibaba Cloud ATS platform and is globally unique within the platform. It is automatically generated during the Agent registration process. In the multi-step registration process through the API, this ID must be carried throughout all steps to ensure that each step is associated with the same Agent and the complete registration process is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2074753647748672512</para>
        /// </summary>
        [NameInMap("AgentRegisterInfoId")]
        [Validation(Required=false)]
        public string AgentRegisterInfoId { get; set; }

        /// <summary>
        /// <para>The version of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.1</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// <para>The ATI name, which is a globally unique identifier in the ATI trust system. Example: ati://v1.0.0.<a href="http://www.example.com">www.example.com</a></para>
        /// <list type="bullet">
        /// <item><description>ati:// — The protocol prefix that identifies this as a resource in the ATI system.</description></item>
        /// <item><description>v1.0.0 — The Agent version number.</description></item>
        /// <item><description><a href="http://www.example.com">www.example.com</a> — The domain name (FQDN) bound to the Agent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ati://v1.0.0.<a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("AtiName")]
        [Validation(Required=false)]
        public string AtiName { get; set; }

        /// <summary>
        /// <para>The creation time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public DescribeAtiAgentRegisterInfoResponseBodyEndpoints Endpoints { get; set; }
        public class DescribeAtiAgentRegisterInfoResponseBodyEndpoints : TeaModel {
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public List<DescribeAtiAgentRegisterInfoResponseBodyEndpointsEndpoint> Endpoint { get; set; }
            public class DescribeAtiAgentRegisterInfoResponseBodyEndpointsEndpoint : TeaModel {
                [NameInMap("AgentUrl")]
                [Validation(Required=false)]
                public string AgentUrl { get; set; }

                [NameInMap("MetadataUrl")]
                [Validation(Required=false)]
                public string MetadataUrl { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Transports")]
                [Validation(Required=false)]
                public DescribeAtiAgentRegisterInfoResponseBodyEndpointsEndpointTransports Transports { get; set; }
                public class DescribeAtiAgentRegisterInfoResponseBodyEndpointsEndpointTransports : TeaModel {
                    [NameInMap("Transport")]
                    [Validation(Required=false)]
                    public List<string> Transport { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>忽略</para>
        /// </summary>
        [NameInMap("IdentityCertSerialNumber")]
        [Validation(Required=false)]
        public string IdentityCertSerialNumber { get; set; }

        /// <summary>
        /// <para>The ID of the verified registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2072277378616354816</para>
        /// </summary>
        [NameInMap("RegistrantId")]
        [Validation(Required=false)]
        public string RegistrantId { get; set; }

        /// <summary>
        /// <para>The name of the registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张xx</para>
        /// </summary>
        [NameInMap("RegistrantName")]
        [Validation(Required=false)]
        public string RegistrantName { get; set; }

        /// <summary>
        /// <para>The reason why the Agent registration review failed.</para>
        /// </summary>
        [NameInMap("RejectReason")]
        [Validation(Required=false)]
        public DescribeAtiAgentRegisterInfoResponseBodyRejectReason RejectReason { get; set; }
        public class DescribeAtiAgentRegisterInfoResponseBodyRejectReason : TeaModel {
            /// <summary>
            /// <para>The detailed information about the Agent registration failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>非法状态</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The type of the review failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACME_VERIFY_FAILED: ACME verification failed.  </description></item>
            /// <item><description>INFO_AUDIT_FAILED: Agent information review failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACME_VERIFY_FAILED</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>忽略</para>
        /// </summary>
        [NameInMap("ServerCertSerialNumber")]
        [Validation(Required=false)]
        public string ServerCertSerialNumber { get; set; }

        /// <summary>
        /// <para>The status of the Agent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Draft: The Agent registration form is being filled out and has not been formally submitted. In the Draft state, only modification and detail viewing operations are supported.</description></item>
        /// <item><description>Private CA Pending Issuance: The Agent registration has been formally submitted. Alibaba Cloud has completed the ACME DNS-01 pre-check and submitted the registration information along with the generated DNS records to CNNIC. The system is waiting for CNNIC to approve and issue the Private CA and complete the TL sealing.</description></item>
        /// <item><description>DNS Pending Verification: CNNIC has approved the registration, issued the Private CA certificate, and completed the TL sealing, but the DNS records of the user have not been verified. The user needs to add the corresponding DNS records in the domain name resolution and complete verification.</description></item>
        /// <item><description>Active: All processes are complete. The Private CA certificate has been issued, the TL has been sealed, and the DNS records have been verified. The Agent is activated and can be discovered and trusted across the network.</description></item>
        /// <item><description>Expired: The Agent identity certificate has expired because the user did not renew the certificate within the validity period.</description></item>
        /// <item><description>Revoked: The Agent certificate has been revoked, the DNS records have been cleaned up, and the Agent can no longer be discovered or trusted. The Agent cannot be restored to the Active state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>活跃</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>忽略</para>
        /// </summary>
        [NameInMap("TrustCard")]
        [Validation(Required=false)]
        public string TrustCard { get; set; }

        /// <summary>
        /// <para>Deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>已废弃</para>
        /// </summary>
        [NameInMap("TrustCardUrl")]
        [Validation(Required=false)]
        public string TrustCardUrl { get; set; }

        /// <summary>
        /// <para>The update time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}

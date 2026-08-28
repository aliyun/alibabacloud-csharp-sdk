// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeAtiAgentRegisterInfoMarketResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeAtiAgentRegisterInfoMarketResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeAtiAgentRegisterInfoMarketResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AddRspDomainServerHoldStatusForGatewayOte</para>
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
            /// <para>The reason for the authentication failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ExplicitDeny: Explicit denial.</description></item>
            /// <item><description>ImplicitDeny: Implicit denial.</description></item>
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
        /// <para>The capability description of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Payment service</para>
        /// </summary>
        [NameInMap("AgentDescription")]
        [Validation(Required=false)]
        public string AgentDescription { get; set; }

        /// <summary>
        /// <para>The display name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestAgent</para>
        /// </summary>
        [NameInMap("AgentDisplayName")]
        [Validation(Required=false)]
        public string AgentDisplayName { get; set; }

        /// <summary>
        /// <para>The host address of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("AgentHost")]
        [Validation(Required=false)]
        public string AgentHost { get; set; }

        /// <summary>
        /// <para>The agent ID, which is uniformly assigned by CNNIC after real-name verification. The AgentID serves as the unique identifier that binds the agent to the real-name authenticated registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gsc01629925@5e0964fd-951c-4e45-b518-d09d4d2db8ca</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The agent registration ID. This ID is automatically generated by the Alibaba Cloud ATS platform and is globally unique within the platform. It is automatically generated during the agent registration process. In the multi-step registration process through the API, this ID must be carried throughout all steps to ensure that each step is associated with the same agent and the complete registration process is completed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2074753647748672512</para>
        /// </summary>
        [NameInMap("AgentRegisterInfoId")]
        [Validation(Required=false)]
        public string AgentRegisterInfoId { get; set; }

        /// <summary>
        /// <para>The agent version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.9.3</para>
        /// </summary>
        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        [NameInMap("Categories")]
        [Validation(Required=false)]
        public DescribeAtiAgentRegisterInfoMarketResponseBodyCategories Categories { get; set; }
        public class DescribeAtiAgentRegisterInfoMarketResponseBodyCategories : TeaModel {
            [NameInMap("category")]
            [Validation(Required=false)]
            public List<string> Category { get; set; }

        }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public DescribeAtiAgentRegisterInfoMarketResponseBodyEndpoints Endpoints { get; set; }
        public class DescribeAtiAgentRegisterInfoMarketResponseBodyEndpoints : TeaModel {
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public List<DescribeAtiAgentRegisterInfoMarketResponseBodyEndpointsEndpoint> Endpoint { get; set; }
            public class DescribeAtiAgentRegisterInfoMarketResponseBodyEndpointsEndpoint : TeaModel {
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
                public DescribeAtiAgentRegisterInfoMarketResponseBodyEndpointsEndpointTransports Transports { get; set; }
                public class DescribeAtiAgentRegisterInfoMarketResponseBodyEndpointsEndpointTransports : TeaModel {
                    [NameInMap("Transport")]
                    [Validation(Required=false)]
                    public List<string> Transport { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4698691</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0629502C-6224-5DC9-A8ED-2ED73A2E3931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the DNS record. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enable: DNS resolution is enabled.</description></item>
        /// <item><description>Disable: DNS resolution is paused.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
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
        [NameInMap("TrustCardContent")]
        [Validation(Required=false)]
        public string TrustCardContent { get; set; }

        /// <summary>
        /// <para>The trust level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Basic authentication</description></item>
        /// <item><description>Enhanced authentication</description></item>
        /// <item><description>Advanced authentication</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>基础认证</para>
        /// </summary>
        [NameInMap("TrustLevel")]
        [Validation(Required=false)]
        public string TrustLevel { get; set; }

    }

}

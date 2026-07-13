// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchAtiAgentRegisterInfoMarketResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public SearchAtiAgentRegisterInfoMarketResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class SearchAtiAgentRegisterInfoMarketResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreateUser</para>
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
            /// <para>The encrypted diagnostic message.</para>
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

        [NameInMap("Agents")]
        [Validation(Required=false)]
        public SearchAtiAgentRegisterInfoMarketResponseBodyAgents Agents { get; set; }
        public class SearchAtiAgentRegisterInfoMarketResponseBodyAgents : TeaModel {
            [NameInMap("Agent")]
            [Validation(Required=false)]
            public List<SearchAtiAgentRegisterInfoMarketResponseBodyAgentsAgent> Agent { get; set; }
            public class SearchAtiAgentRegisterInfoMarketResponseBodyAgentsAgent : TeaModel {
                [NameInMap("AgentDescription")]
                [Validation(Required=false)]
                public string AgentDescription { get; set; }

                [NameInMap("AgentDisplayName")]
                [Validation(Required=false)]
                public string AgentDisplayName { get; set; }

                [NameInMap("AgentHost")]
                [Validation(Required=false)]
                public string AgentHost { get; set; }

                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                [NameInMap("AgentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("Protocols")]
                [Validation(Required=false)]
                public SearchAtiAgentRegisterInfoMarketResponseBodyAgentsAgentProtocols Protocols { get; set; }
                public class SearchAtiAgentRegisterInfoMarketResponseBodyAgentsAgentProtocols : TeaModel {
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public List<string> Protocol { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TrustCardUrl")]
                [Validation(Required=false)]
                public string TrustCardUrl { get; set; }

                [NameInMap("TrustLevel")]
                [Validation(Required=false)]
                public string TrustLevel { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per batch query.</para>
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
        /// <para>The current page number. Minimum value: <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for the paged query. Settings: maximum value: <b>100</b>. Default value: <b>20</b>. This parameter controls paging behavior.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}

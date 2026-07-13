// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListAtiAgentRegisterInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ListAtiAgentRegisterInfosResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ListAtiAgentRegisterInfosResponseBodyAccessDeniedDetail : TeaModel {
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
            /// <para>The encrypted diagnostic message.</para>
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

        [NameInMap("AgentRegisterInfos")]
        [Validation(Required=false)]
        public ListAtiAgentRegisterInfosResponseBodyAgentRegisterInfos AgentRegisterInfos { get; set; }
        public class ListAtiAgentRegisterInfosResponseBodyAgentRegisterInfos : TeaModel {
            [NameInMap("AgentRegisterInfo")]
            [Validation(Required=false)]
            public List<ListAtiAgentRegisterInfosResponseBodyAgentRegisterInfosAgentRegisterInfo> AgentRegisterInfo { get; set; }
            public class ListAtiAgentRegisterInfosResponseBodyAgentRegisterInfosAgentRegisterInfo : TeaModel {
                [NameInMap("AgentDisplayName")]
                [Validation(Required=false)]
                public string AgentDisplayName { get; set; }

                [NameInMap("AgentHost")]
                [Validation(Required=false)]
                public string AgentHost { get; set; }

                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                [NameInMap("AgentRegisterInfoId")]
                [Validation(Required=false)]
                public string AgentRegisterInfoId { get; set; }

                [NameInMap("AgentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                [NameInMap("AtiName")]
                [Validation(Required=false)]
                public string AtiName { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public string CreateTimestamp { get; set; }

                [NameInMap("Endpoints")]
                [Validation(Required=false)]
                public ListAtiAgentRegisterInfosResponseBodyAgentRegisterInfosAgentRegisterInfoEndpoints Endpoints { get; set; }
                public class ListAtiAgentRegisterInfosResponseBodyAgentRegisterInfosAgentRegisterInfoEndpoints : TeaModel {
                    [NameInMap("Endpoint")]
                    [Validation(Required=false)]
                    public List<ListAtiAgentRegisterInfosResponseBodyAgentRegisterInfosAgentRegisterInfoEndpointsEndpoint> Endpoint { get; set; }
                    public class ListAtiAgentRegisterInfosResponseBodyAgentRegisterInfosAgentRegisterInfoEndpointsEndpoint : TeaModel {
                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public string UpdateTimestamp { get; set; }

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
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4698691</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page set for the paged query. This is the paging size. Maximum value: <b>100</b>. Default value: <b>20</b>. Settings determine how many rows are displayed per page.</para>
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
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}

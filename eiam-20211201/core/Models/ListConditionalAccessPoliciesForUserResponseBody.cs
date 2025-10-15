// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListConditionalAccessPoliciesForUserResponseBody : TeaModel {
        [NameInMap("ConditionalAccessPolicies")]
        [Validation(Required=false)]
        public List<ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPolicies> ConditionalAccessPolicies { get; set; }
        public class ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPolicies : TeaModel {
            /// <summary>
            /// <para>IDaaS EIAM 条件访问策略Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>cap_m5etun43kejxphsbke6mjxxxxx</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyId")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyId { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 条件访问策略名称</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyName")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyName { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 条件访问策略类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:alibaba:idaas:authn:access:policy:system</para>
            /// </summary>
            [NameInMap("ConditionalAccessPolicyType")]
            [Validation(Required=false)]
            public string ConditionalAccessPolicyType { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 条件访问策略内容</para>
            /// </summary>
            [NameInMap("ConditionsConfig")]
            [Validation(Required=false)]
            public ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesConditionsConfig ConditionsConfig { get; set; }
            public class ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesConditionsConfig : TeaModel {
                /// <summary>
                /// <para>条件访问策略目标应用</para>
                /// </summary>
                [NameInMap("Applications")]
                [Validation(Required=false)]
                public ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesConditionsConfigApplications Applications { get; set; }
                public class ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesConditionsConfigApplications : TeaModel {
                    /// <summary>
                    /// <para>排除的应用</para>
                    /// </summary>
                    [NameInMap("ExcludeApplications")]
                    [Validation(Required=false)]
                    public List<string> ExcludeApplications { get; set; }

                    /// <summary>
                    /// <para>选择的应用</para>
                    /// </summary>
                    [NameInMap("IncludeApplications")]
                    [Validation(Required=false)]
                    public List<string> IncludeApplications { get; set; }

                }

                /// <summary>
                /// <para>条件访问策略网络区域</para>
                /// </summary>
                [NameInMap("NetworkZones")]
                [Validation(Required=false)]
                public ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesConditionsConfigNetworkZones NetworkZones { get; set; }
                public class ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesConditionsConfigNetworkZones : TeaModel {
                    /// <summary>
                    /// <para>排除的网络区域</para>
                    /// </summary>
                    [NameInMap("ExcludeNetworkZones")]
                    [Validation(Required=false)]
                    public List<string> ExcludeNetworkZones { get; set; }

                    /// <summary>
                    /// <para>选择的网络区域</para>
                    /// </summary>
                    [NameInMap("IncludeNetworkZones")]
                    [Validation(Required=false)]
                    public List<string> IncludeNetworkZones { get; set; }

                }

                /// <summary>
                /// <para>条件访问策略目标用户</para>
                /// </summary>
                [NameInMap("Users")]
                [Validation(Required=false)]
                public ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesConditionsConfigUsers Users { get; set; }
                public class ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesConditionsConfigUsers : TeaModel {
                    /// <summary>
                    /// <para>排除的用户组</para>
                    /// </summary>
                    [NameInMap("ExcludeGroups")]
                    [Validation(Required=false)]
                    public List<string> ExcludeGroups { get; set; }

                    /// <summary>
                    /// <para>排除的组织</para>
                    /// </summary>
                    [NameInMap("ExcludeOrganizationalUnits")]
                    [Validation(Required=false)]
                    public List<string> ExcludeOrganizationalUnits { get; set; }

                    /// <summary>
                    /// <para>排除的用户</para>
                    /// </summary>
                    [NameInMap("ExcludeUsers")]
                    [Validation(Required=false)]
                    public List<string> ExcludeUsers { get; set; }

                    /// <summary>
                    /// <para>选择的用户组</para>
                    /// </summary>
                    [NameInMap("IncludeGroups")]
                    [Validation(Required=false)]
                    public List<string> IncludeGroups { get; set; }

                    /// <summary>
                    /// <para>选择的组织</para>
                    /// </summary>
                    [NameInMap("IncludeOrganizationalUnits")]
                    [Validation(Required=false)]
                    public List<string> IncludeOrganizationalUnits { get; set; }

                    /// <summary>
                    /// <para>选择的用户</para>
                    /// </summary>
                    [NameInMap("IncludeUsers")]
                    [Validation(Required=false)]
                    public List<string> IncludeUsers { get; set; }

                }

            }

            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741857554000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 条件访问策略执行Action</para>
            /// </summary>
            [NameInMap("DecisionConfig")]
            [Validation(Required=false)]
            public ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesDecisionConfig DecisionConfig { get; set; }
            public class ListConditionalAccessPoliciesForUserResponseBodyConditionalAccessPoliciesDecisionConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>disabled</para>
                /// </summary>
                [NameInMap("ActiveSessionReuseStatus")]
                [Validation(Required=false)]
                public string ActiveSessionReuseStatus { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 条件访问策略决策Action</para>
                /// 
                /// <b>Example:</b>
                /// <para>allow</para>
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 条件访问策略重复认证时间间隔(秒)</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("MfaAuthenticationIntervalSeconds")]
                [Validation(Required=false)]
                public long? MfaAuthenticationIntervalSeconds { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 条件访问策略允许使用的mfa类型</para>
                /// </summary>
                [NameInMap("MfaAuthenticationMethods")]
                [Validation(Required=false)]
                public List<string> MfaAuthenticationMethods { get; set; }

                /// <summary>
                /// <para>IDaaS EIAM 条件访问策略Mfa类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>directly_access</para>
                /// </summary>
                [NameInMap("MfaType")]
                [Validation(Required=false)]
                public string MfaType { get; set; }

            }

            /// <summary>
            /// <para>IDaaS EIAM 条件访问策略执行类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>enforcement</para>
            /// </summary>
            [NameInMap("DecisionType")]
            [Validation(Required=false)]
            public string DecisionType { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 条件访问策略描述</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 条件访问策略执行点</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:alibaba:idaas:authn:access:rule:eval_at:after_step1</para>
            /// </summary>
            [NameInMap("EvaluateAt")]
            [Validation(Required=false)]
            public string EvaluateAt { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_oynbcyaaejuik6b37eldz4xxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>更新时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1741857554000</para>
            /// </summary>
            [NameInMap("LastUpdatedTime")]
            [Validation(Required=false)]
            public long? LastUpdatedTime { get; set; }

            /// <summary>
            /// <para>优先级</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 条件访问策略启用禁用状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

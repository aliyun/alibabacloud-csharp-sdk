// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class GetEgressProxyRuleGroupAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-10-16T15:34:56Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eppool-gw80d96a96ca0b00****</para>
        /// </summary>
        [NameInMap("EgressProxyIpPoolId")]
        [Validation(Required=false)]
        public string EgressProxyIpPoolId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eprg-uf60966a9633667c****</para>
        /// </summary>
        [NameInMap("EgressProxyRuleGroupId")]
        [Validation(Required=false)]
        public string EgressProxyRuleGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("EgressProxyRuleGroupName")]
        [Validation(Required=false)]
        public string EgressProxyRuleGroupName { get; set; }

        [NameInMap("EgressProxyRules")]
        [Validation(Required=false)]
        public GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRules EgressProxyRules { get; set; }
        public class GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRules : TeaModel {
            [NameInMap("PostResponse")]
            [Validation(Required=false)]
            public List<GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPostResponse> PostResponse { get; set; }
            public class GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPostResponse : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPostResponseConditions> Conditions { get; set; }
                public class GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPostResponseConditions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>request:DestinationDomain</para>
                    /// </summary>
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>StringEquals</para>
                    /// </summary>
                    [NameInMap("ConditionOperator")]
                    [Validation(Required=false)]
                    public string ConditionOperator { get; set; }

                    [NameInMap("ConditionValues")]
                    [Validation(Required=false)]
                    public List<string> ConditionValues { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-01-15T11:58:34Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>epr-gw80bb6a91dbb775****</para>
                /// </summary>
                [NameInMap("EgressProxyRuleId")]
                [Validation(Required=false)]
                public string EgressProxyRuleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("EgressProxyRuleName")]
                [Validation(Required=false)]
                public string EgressProxyRuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>66</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            [NameInMap("PreDns")]
            [Validation(Required=false)]
            public List<GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPreDns> PreDns { get; set; }
            public class GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPreDns : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPreDnsConditions> Conditions { get; set; }
                public class GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPreDnsConditions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>request:DestinationDomain</para>
                    /// </summary>
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>StringEquals</para>
                    /// </summary>
                    [NameInMap("ConditionOperator")]
                    [Validation(Required=false)]
                    public string ConditionOperator { get; set; }

                    [NameInMap("ConditionValues")]
                    [Validation(Required=false)]
                    public List<string> ConditionValues { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-08-19T03:34:29Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>epr-gw80bb6a91dbb775****</para>
                /// </summary>
                [NameInMap("EgressProxyRuleId")]
                [Validation(Required=false)]
                public string EgressProxyRuleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("EgressProxyRuleName")]
                [Validation(Required=false)]
                public string EgressProxyRuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>66</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            [NameInMap("PreRequest")]
            [Validation(Required=false)]
            public List<GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPreRequest> PreRequest { get; set; }
            public class GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPreRequest : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPreRequestConditions> Conditions { get; set; }
                public class GetEgressProxyRuleGroupAttributeResponseBodyEgressProxyRulesPreRequestConditions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>request:DestinationDomain</para>
                    /// </summary>
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>StringEquals</para>
                    /// </summary>
                    [NameInMap("ConditionOperator")]
                    [Validation(Required=false)]
                    public string ConditionOperator { get; set; }

                    [NameInMap("ConditionValues")]
                    [Validation(Required=false)]
                    public List<string> ConditionValues { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-12-20T15:58:33.343</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>epr-gw80bb6a91dbb775****</para>
                /// </summary>
                [NameInMap("EgressProxyRuleId")]
                [Validation(Required=false)]
                public string EgressProxyRuleId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("EgressProxyRuleName")]
                [Validation(Required=false)]
                public string EgressProxyRuleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>66</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01A05AB5-5BED-56ED-8EE9-304FBC2F8537</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmzvr2nr****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetEgressProxyRuleGroupAttributeResponseBodyTags> Tags { get; set; }
        public class GetEgressProxyRuleGroupAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>epg</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

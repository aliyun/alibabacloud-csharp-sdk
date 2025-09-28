// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44ANBjKZmQeKnaB1fXRq06w7sFYK3MUcCALMD9qQbmEiE</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("policies")]
        [Validation(Required=false)]
        public List<ListIntegrationPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListIntegrationPoliciesResponseBodyPolicies : TeaModel {
            [NameInMap("bindResource")]
            [Validation(Required=false)]
            public ListIntegrationPoliciesResponseBodyPoliciesBindResource BindResource { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesBindResource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cv68tt87d78vyc89zy9v</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ManagedKubernetes</para>
                /// </summary>
                [NameInMap("clusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100.100.0.1/16</para>
                /// </summary>
                [NameInMap("vpcCidr")]
                [Validation(Required=false)]
                public string VpcCidr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-uf664nyle5khp5d4d7hdo</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("entityGroup")]
            [Validation(Required=false)]
            public ListIntegrationPoliciesResponseBodyPoliciesEntityGroup EntityGroup { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eg-b79f65d11fb94e779867cf937c3a3002</para>
                /// </summary>
                [NameInMap("entityGroupId")]
                [Validation(Required=false)]
                public string EntityGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-eg</para>
                /// </summary>
                [NameInMap("entityGroupName")]
                [Validation(Required=false)]
                public string EntityGroupName { get; set; }

                [NameInMap("entityRules")]
                [Validation(Required=false)]
                public ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRules EntityRules { get; set; }
                public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRules : TeaModel {
                    [NameInMap("annotations")]
                    [Validation(Required=false)]
                    public List<ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesAnnotations> Annotations { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesAnnotations : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                    [NameInMap("entityTypes")]
                    [Validation(Required=false)]
                    public List<string> EntityTypes { get; set; }

                    [NameInMap("fieldRules")]
                    [Validation(Required=false)]
                    public List<ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesFieldRules> FieldRules { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesFieldRules : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("fieldKey")]
                        [Validation(Required=false)]
                        public string FieldKey { get; set; }

                        [NameInMap("fieldValues")]
                        [Validation(Required=false)]
                        public List<string> FieldValues { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                    }

                    [NameInMap("instanceIds")]
                    [Validation(Required=false)]
                    public List<string> InstanceIds { get; set; }

                    [NameInMap("ipMatchRule")]
                    [Validation(Required=false)]
                    public ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesIpMatchRule IpMatchRule { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesIpMatchRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100.100.1.0/16</para>
                        /// </summary>
                        [NameInMap("ipCidr")]
                        [Validation(Required=false)]
                        public string IpCidr { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("ipFieldKey")]
                        [Validation(Required=false)]
                        public string IpFieldKey { get; set; }

                    }

                    [NameInMap("labels")]
                    [Validation(Required=false)]
                    public List<ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesLabels> Labels { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesLabels : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                    [NameInMap("regionIds")]
                    [Validation(Required=false)]
                    public List<string> RegionIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rg-5i6dbwxfxuqihk7k</para>
                    /// </summary>
                    [NameInMap("resourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesTags> Tags { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesTags : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                }

                [NameInMap("query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-heyuan</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1236812738</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-api</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            [NameInMap("managedInfo")]
            [Validation(Required=false)]
            public ListIntegrationPoliciesResponseBodyPoliciesManagedInfo ManagedInfo { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesManagedInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-xxxxx</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-xxxxxx</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policy-ac38a7cb02d14ff48bc9f97d0a75063e</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6f5HSsg3AP</para>
            /// </summary>
            [NameInMap("policyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-xxxxx</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("subAddonRelease")]
            [Validation(Required=false)]
            public ListIntegrationPoliciesResponseBodyPoliciesSubAddonRelease SubAddonRelease { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesSubAddonRelease : TeaModel {
                [NameInMap("ready")]
                [Validation(Required=false)]
                public int? Ready { get; set; }

                [NameInMap("total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListIntegrationPoliciesResponseBodyPoliciesTags> Tags { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>128470923</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-api</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-78B0FECD14B5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

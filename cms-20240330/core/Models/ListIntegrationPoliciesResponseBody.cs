// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>Page size
        /// Default value:
        ///     50
        /// Maximum value:
        ///     50</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Pagination token</para>
        /// 
        /// <b>Example:</b>
        /// <para>44ANBjKZmQeKnaB1fXRq06w7sFYK3MUcCALMD9qQbmEiE</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Access policy list</para>
        /// </summary>
        [NameInMap("policies")]
        [Validation(Required=false)]
        public List<ListIntegrationPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListIntegrationPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>Bound resource information</para>
            /// </summary>
            [NameInMap("bindResource")]
            [Validation(Required=false)]
            public ListIntegrationPoliciesResponseBodyPoliciesBindResource BindResource { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesBindResource : TeaModel {
                /// <summary>
                /// <para>Cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cv68tt87d78vyc89zy9v</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>Cluster type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ManagedKubernetes</para>
                /// </summary>
                [NameInMap("clusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// <para>VPC CIDR</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.100.0.1/16</para>
                /// </summary>
                [NameInMap("vpcCidr")]
                [Validation(Required=false)]
                public string VpcCidr { get; set; }

                /// <summary>
                /// <para>Virtual Private Cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf664nyle5khp5d4d7hdo</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>Container environment umodel installation status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("csUmodelStatus")]
            [Validation(Required=false)]
            public bool? CsUmodelStatus { get; set; }

            /// <summary>
            /// <para>Entity group</para>
            /// </summary>
            [NameInMap("entityGroup")]
            [Validation(Required=false)]
            public ListIntegrationPoliciesResponseBodyPoliciesEntityGroup EntityGroup { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroup : TeaModel {
                /// <summary>
                /// <para>Description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Entity group ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>eg-b79f65d11fb94e779867cf937c3a3002</para>
                /// </summary>
                [NameInMap("entityGroupId")]
                [Validation(Required=false)]
                public string EntityGroupId { get; set; }

                /// <summary>
                /// <para>Entity group name</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-eg</para>
                /// </summary>
                [NameInMap("entityGroupName")]
                [Validation(Required=false)]
                public string EntityGroupName { get; set; }

                /// <summary>
                /// <para>Entity group</para>
                /// </summary>
                [NameInMap("entityRules")]
                [Validation(Required=false)]
                public ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRules EntityRules { get; set; }
                public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRules : TeaModel {
                    /// <summary>
                    /// <para>Annotations</para>
                    /// </summary>
                    [NameInMap("annotations")]
                    [Validation(Required=false)]
                    public List<ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesAnnotations> Annotations { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesAnnotations : TeaModel {
                        /// <summary>
                        /// <para>Operation to be performed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <para>Tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>Tag values</para>
                        /// </summary>
                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                    /// <summary>
                    /// <para>List of entity types</para>
                    /// </summary>
                    [NameInMap("entityTypes")]
                    [Validation(Required=false)]
                    public List<string> EntityTypes { get; set; }

                    /// <summary>
                    /// <para>Field rules</para>
                    /// </summary>
                    [NameInMap("fieldRules")]
                    [Validation(Required=false)]
                    public List<ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesFieldRules> FieldRules { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesFieldRules : TeaModel {
                        /// <summary>
                        /// <para>Unique identifier for the field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("fieldKey")]
                        [Validation(Required=false)]
                        public string FieldKey { get; set; }

                        /// <summary>
                        /// <para>Field content, multiple values separated by English commas.</para>
                        /// </summary>
                        [NameInMap("fieldValues")]
                        [Validation(Required=false)]
                        public List<string> FieldValues { get; set; }

                        /// <summary>
                        /// <para>Operation to be performed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                    }

                    /// <summary>
                    /// <para>Instance IDs.</para>
                    /// </summary>
                    [NameInMap("instanceIds")]
                    [Validation(Required=false)]
                    public List<string> InstanceIds { get; set; }

                    /// <summary>
                    /// <para>IP match rule</para>
                    /// </summary>
                    [NameInMap("ipMatchRule")]
                    [Validation(Required=false)]
                    public ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesIpMatchRule IpMatchRule { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesIpMatchRule : TeaModel {
                        /// <summary>
                        /// <para>IP segment</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100.100.1.0/16</para>
                        /// </summary>
                        [NameInMap("ipCidr")]
                        [Validation(Required=false)]
                        public string IpCidr { get; set; }

                        /// <summary>
                        /// <para>Key of the IP field</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxxx</para>
                        /// </summary>
                        [NameInMap("ipFieldKey")]
                        [Validation(Required=false)]
                        public string IpFieldKey { get; set; }

                    }

                    /// <summary>
                    /// <para>Labels</para>
                    /// </summary>
                    [NameInMap("labels")]
                    [Validation(Required=false)]
                    public List<ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesLabels> Labels { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesLabels : TeaModel {
                        /// <summary>
                        /// <para>Operation to be performed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <para>Tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>Tag values</para>
                        /// </summary>
                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                    /// <summary>
                    /// <para>List of region IDs.</para>
                    /// </summary>
                    [NameInMap("regionIds")]
                    [Validation(Required=false)]
                    public List<string> RegionIds { get; set; }

                    /// <summary>
                    /// <para>Resource group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rg-5i6dbwxfxuqihk7k</para>
                    /// </summary>
                    [NameInMap("resourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    /// <summary>
                    /// <para>Instance tag information.</para>
                    /// </summary>
                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesTags> Tags { get; set; }
                    public class ListIntegrationPoliciesResponseBodyPoliciesEntityGroupEntityRulesTags : TeaModel {
                        /// <summary>
                        /// <para>Operation to be performed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <para>Tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>Tag value.</para>
                        /// </summary>
                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                }

                /// <summary>
                /// <para>Search keywords, supporting document library name and description</para>
                /// 
                /// <b>Example:</b>
                /// <para>哈弗</para>
                /// </summary>
                [NameInMap("query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-heyuan</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1236812738</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-api</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>Billing type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS_Pro</para>
            /// </summary>
            [NameInMap("feePackage")]
            [Validation(Required=false)]
            public string FeePackage { get; set; }

            /// <summary>
            /// <para>Policy network management information.</para>
            /// </summary>
            [NameInMap("managedInfo")]
            [Validation(Required=false)]
            public ListIntegrationPoliciesResponseBodyPoliciesManagedInfo ManagedInfo { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesManagedInfo : TeaModel {
                /// <summary>
                /// <para>ENI card ID of the managed probe. For example: eni-xxxx.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eni-12345678</para>
                /// </summary>
                [NameInMap("eniId")]
                [Validation(Required=false)]
                public string EniId { get; set; }

                /// <summary>
                /// <para>Security group ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxxxx</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>VSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxxxxx</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>Policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy-ac38a7cb02d14ff48bc9f97d0a75063e</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>Rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6f5HSsg3AP</para>
            /// </summary>
            [NameInMap("policyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>Access center policy type</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxxxx</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Number of sub-releases</para>
            /// </summary>
            [NameInMap("subAddonRelease")]
            [Validation(Required=false)]
            public ListIntegrationPoliciesResponseBodyPoliciesSubAddonRelease SubAddonRelease { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesSubAddonRelease : TeaModel {
                /// <summary>
                /// <para>Number of ready sub-releases</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("ready")]
                [Validation(Required=false)]
                public int? Ready { get; set; }

                /// <summary>
                /// <para>Number of rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>278</para>
                /// </summary>
                [NameInMap("total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// <para>Resource tag key values.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListIntegrationPoliciesResponseBodyPoliciesTags> Tags { get; set; }
            public class ListIntegrationPoliciesResponseBodyPoliciesTags : TeaModel {
                /// <summary>
                /// <para>Tag key</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Match value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>128470923</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-api</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-78B0FECD14B5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of entries</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetIntegrationPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The integration policy.</para>
        /// </summary>
        [NameInMap("policy")]
        [Validation(Required=false)]
        public GetIntegrationPolicyResponseBodyPolicy Policy { get; set; }
        public class GetIntegrationPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>The information about the attached resource.</para>
            /// </summary>
            [NameInMap("bindResource")]
            [Validation(Required=false)]
            public GetIntegrationPolicyResponseBodyPolicyBindResource BindResource { get; set; }
            public class GetIntegrationPolicyResponseBodyPolicyBindResource : TeaModel {
                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00b1630f02814f95a9bce717d8d56bb2</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The cluster type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ManagedKubernetes</para>
                /// </summary>
                [NameInMap("clusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                /// <summary>
                /// <para>The CIDR block of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.12.0.1/16</para>
                /// </summary>
                [NameInMap("vpcCidr")]
                [Validation(Required=false)]
                public string VpcCidr { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zegqpeyxplhtmdg70xnr</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The installation status of umodel in the container environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("csUmodelStatus")]
            [Validation(Required=false)]
            public bool? CsUmodelStatus { get; set; }

            /// <summary>
            /// <para>The entity group.</para>
            /// </summary>
            [NameInMap("entityGroup")]
            [Validation(Required=false)]
            public GetIntegrationPolicyResponseBodyPolicyEntityGroup EntityGroup { get; set; }
            public class GetIntegrationPolicyResponseBodyPolicyEntityGroup : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxxxx</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The entity group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eg-b79f65d11fb94e779867cf937c3a3002</para>
                /// </summary>
                [NameInMap("entityGroupId")]
                [Validation(Required=false)]
                public string EntityGroupId { get; set; }

                /// <summary>
                /// <para>The entity group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod-database</para>
                /// </summary>
                [NameInMap("entityGroupName")]
                [Validation(Required=false)]
                public string EntityGroupName { get; set; }

                /// <summary>
                /// <para>The entity rules.</para>
                /// </summary>
                [NameInMap("entityRules")]
                [Validation(Required=false)]
                public GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRules EntityRules { get; set; }
                public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRules : TeaModel {
                    /// <summary>
                    /// <para>The comments.</para>
                    /// </summary>
                    [NameInMap("annotations")]
                    [Validation(Required=false)]
                    public List<GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesAnnotations> Annotations { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesAnnotations : TeaModel {
                        /// <summary>
                        /// <para>The operation to perform.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>use</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The tag values.</para>
                        /// </summary>
                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of entity types.</para>
                    /// </summary>
                    [NameInMap("entityTypes")]
                    [Validation(Required=false)]
                    public List<string> EntityTypes { get; set; }

                    /// <summary>
                    /// <para>The list of property rules.</para>
                    /// </summary>
                    [NameInMap("fieldRules")]
                    [Validation(Required=false)]
                    public List<GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesFieldRules> FieldRules { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesFieldRules : TeaModel {
                        /// <summary>
                        /// <para>The unique identifier of the field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("fieldKey")]
                        [Validation(Required=false)]
                        public string FieldKey { get; set; }

                        /// <summary>
                        /// <para>The field content.</para>
                        /// </summary>
                        [NameInMap("fieldValues")]
                        [Validation(Required=false)]
                        public List<string> FieldValues { get; set; }

                        /// <summary>
                        /// <para>The operation to perform.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                    }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// </summary>
                    [NameInMap("instanceIds")]
                    [Validation(Required=false)]
                    public List<string> InstanceIds { get; set; }

                    /// <summary>
                    /// <para>The IP address matching rule.</para>
                    /// </summary>
                    [NameInMap("ipMatchRule")]
                    [Validation(Required=false)]
                    public GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesIpMatchRule IpMatchRule { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesIpMatchRule : TeaModel {
                        /// <summary>
                        /// <para>The IP address CIDR block.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10.10.0.1/16</para>
                        /// </summary>
                        [NameInMap("ipCidr")]
                        [Validation(Required=false)]
                        public string IpCidr { get; set; }

                        /// <summary>
                        /// <para>The key of the IP address field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-key</para>
                        /// </summary>
                        [NameInMap("ipFieldKey")]
                        [Validation(Required=false)]
                        public string IpFieldKey { get; set; }

                    }

                    /// <summary>
                    /// <para>The labels.</para>
                    /// </summary>
                    [NameInMap("labels")]
                    [Validation(Required=false)]
                    public List<GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesLabels> Labels { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesLabels : TeaModel {
                        /// <summary>
                        /// <para>The operation to perform.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <para>The tag key of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key1</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The list of tag values.</para>
                        /// </summary>
                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of region IDs.</para>
                    /// </summary>
                    [NameInMap("regionIds")]
                    [Validation(Required=false)]
                    public List<string> RegionIds { get; set; }

                    /// <summary>
                    /// <para>The resource group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rg-aek3aqsuvlv3yyq</para>
                    /// </summary>
                    [NameInMap("resourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    /// <summary>
                    /// <para>The tags.</para>
                    /// </summary>
                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesTags> Tags { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesTags : TeaModel {
                        /// <summary>
                        /// <para>The operation to perform.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <para>The tag key of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key2</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The list of tag values.</para>
                        /// </summary>
                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                }

                /// <summary>
                /// <para>The query condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>status: 200 AND totalTime &gt; 0.5</para>
                /// </summary>
                [NameInMap("query")]
                [Validation(Required=false)]
                public string Query { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-heyuan</para>
                /// </summary>
                [NameInMap("regionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>u123456</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-api</para>
                /// </summary>
                [NameInMap("workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            /// <summary>
            /// <para>The policy management information.</para>
            /// </summary>
            [NameInMap("managedInfo")]
            [Validation(Required=false)]
            public GetIntegrationPolicyResponseBodyPolicyManagedInfo ManagedInfo { get; set; }
            public class GetIntegrationPolicyResponseBodyPolicyManagedInfo : TeaModel {
                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxxxxx</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxxxxxxxx</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy-c9efed2b99c348d49e589c5f780fc074</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ControlPolicy4DetailVportInfo</para>
            /// </summary>
            [NameInMap("policyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The type of the integration policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS</para>
            /// </summary>
            [NameInMap("policyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-heyuan</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxxxx</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetIntegrationPolicyResponseBodyPolicyTags> Tags { get; set; }
            public class GetIntegrationPolicyResponseBodyPolicyTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>use</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u123456</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prometheus</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

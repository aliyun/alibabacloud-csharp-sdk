// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetIntegrationPolicyResponseBody : TeaModel {
        [NameInMap("policy")]
        [Validation(Required=false)]
        public GetIntegrationPolicyResponseBodyPolicy Policy { get; set; }
        public class GetIntegrationPolicyResponseBodyPolicy : TeaModel {
            [NameInMap("bindResource")]
            [Validation(Required=false)]
            public GetIntegrationPolicyResponseBodyPolicyBindResource BindResource { get; set; }
            public class GetIntegrationPolicyResponseBodyPolicyBindResource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>00b1630f02814f95a9bce717d8d56bb2</para>
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
                /// <para>10.12.0.1/16</para>
                /// </summary>
                [NameInMap("vpcCidr")]
                [Validation(Required=false)]
                public string VpcCidr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-2zegqpeyxplhtmdg70xnr</para>
                /// </summary>
                [NameInMap("vpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            [NameInMap("entityGroup")]
            [Validation(Required=false)]
            public GetIntegrationPolicyResponseBodyPolicyEntityGroup EntityGroup { get; set; }
            public class GetIntegrationPolicyResponseBodyPolicyEntityGroup : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxx</para>
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
                /// <para>prod-database</para>
                /// </summary>
                [NameInMap("entityGroupName")]
                [Validation(Required=false)]
                public string EntityGroupName { get; set; }

                [NameInMap("entityRules")]
                [Validation(Required=false)]
                public GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRules EntityRules { get; set; }
                public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRules : TeaModel {
                    [NameInMap("annotations")]
                    [Validation(Required=false)]
                    public List<GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesAnnotations> Annotations { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesAnnotations : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>use</para>
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
                    public List<GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesFieldRules> FieldRules { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesFieldRules : TeaModel {
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
                    public GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesIpMatchRule IpMatchRule { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesIpMatchRule : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>10.10.0.1/16</para>
                        /// </summary>
                        [NameInMap("ipCidr")]
                        [Validation(Required=false)]
                        public string IpCidr { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test-key</para>
                        /// </summary>
                        [NameInMap("ipFieldKey")]
                        [Validation(Required=false)]
                        public string IpFieldKey { get; set; }

                    }

                    [NameInMap("labels")]
                    [Validation(Required=false)]
                    public List<GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesLabels> Labels { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesLabels : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>key1</para>
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
                    /// <para>rg-aek3aqsuvlv3yyq</para>
                    /// </summary>
                    [NameInMap("resourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    [NameInMap("tags")]
                    [Validation(Required=false)]
                    public List<GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesTags> Tags { get; set; }
                    public class GetIntegrationPolicyResponseBodyPolicyEntityGroupEntityRulesTags : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>add</para>
                        /// </summary>
                        [NameInMap("op")]
                        [Validation(Required=false)]
                        public string Op { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>key2</para>
                        /// </summary>
                        [NameInMap("tagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("tagValues")]
                        [Validation(Required=false)]
                        public List<string> TagValues { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>status: 200 AND totalTime &gt; 0.5</para>
                /// </summary>
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
                /// <para>u123456</para>
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
            public GetIntegrationPolicyResponseBodyPolicyManagedInfo ManagedInfo { get; set; }
            public class GetIntegrationPolicyResponseBodyPolicyManagedInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sg-xxxxxx</para>
                /// </summary>
                [NameInMap("securityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-xxxxxxxxx</para>
                /// </summary>
                [NameInMap("vswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>policy-c9efed2b99c348d49e589c5f780fc074</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ControlPolicy4DetailVportInfo</para>
            /// </summary>
            [NameInMap("policyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS</para>
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

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetIntegrationPolicyResponseBodyPolicyTags> Tags { get; set; }
            public class GetIntegrationPolicyResponseBodyPolicyTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>use</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>db</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>u123456</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prometheus</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

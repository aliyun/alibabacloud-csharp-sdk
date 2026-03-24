// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateIntegrationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The entity group used to create the policy. You can quickly create a policy using an entity group. The clusterId and vpcId parameters are independent of each other.</para>
        /// </summary>
        [NameInMap("entityGroup")]
        [Validation(Required=false)]
        public CreateIntegrationPolicyRequestEntityGroup EntityGroup { get; set; }
        public class CreateIntegrationPolicyRequestEntityGroup : TeaModel {
            /// <summary>
            /// <para>The cluster entity type. Examples: acs.ack.cluster, acs.one.cluster, and acs.asi.cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs.ack.cluster</para>
            /// </summary>
            [NameInMap("clusterEntityType")]
            [Validation(Required=false)]
            public string ClusterEntityType { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>na61prod3-na61cloudhdfsssd</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("clusterNamespace")]
            [Validation(Required=false)]
            public string ClusterNamespace { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable unique policy binding. If this parameter is set to true, you can create multiple policies for a container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ture</para>
            /// </summary>
            [NameInMap("disablePolicyShare")]
            [Validation(Required=false)]
            public bool? DisablePolicyShare { get; set; }

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
            /// <para>The ID of the user who owns the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12xxxx</para>
            /// </summary>
            [NameInMap("entityUserId")]
            [Validation(Required=false)]
            public string EntityUserId { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp18fgg3ffxa9czna40xt</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-database</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values: CS, ECS, and Cloud.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS</para>
        /// </summary>
        [NameInMap("policyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz2km4kmhtbii</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateIntegrationPolicyRequestTags> Tags { get; set; }
        public class CreateIntegrationPolicyRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>use</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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

}

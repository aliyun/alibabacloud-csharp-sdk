// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateIntegrationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The policy creation version. Valid values: v1 and v2. If this parameter is not specified or is left empty, v2 is used. If v1 is specified, a v1-compatible environment is created for ECS and Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("apiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The entity group used to create the policy. You can use the entity group for quick creation. The clusterId and vpcId parameters are independent of each other.</para>
        /// </summary>
        [NameInMap("entityGroup")]
        [Validation(Required=false)]
        public CreateIntegrationPolicyRequestEntityGroup EntityGroup { get; set; }
        public class CreateIntegrationPolicyRequestEntityGroup : TeaModel {
            /// <summary>
            /// <para>The cluster entity type, such as acs.ack.cluster, acs.one.cluster, acs.asi.cluster, or others.</para>
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

            /// <summary>
            /// <para>The namespace where the probe is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-prom</para>
            /// </summary>
            [NameInMap("clusterNamespace")]
            [Validation(Required=false)]
            public string ClusterNamespace { get; set; }

            /// <summary>
            /// <para>Specifies whether to disable the unique binding of the policy. If this parameter is set to true, you can create multiple policies for a single container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>The ID of the user to which the cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12xxxx</para>
            /// </summary>
            [NameInMap("entityUserId")]
            [Validation(Required=false)]
            public string EntityUserId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
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

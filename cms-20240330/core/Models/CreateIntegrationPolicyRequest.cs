// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateIntegrationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Entity group for creating the policy. Policies can be quickly created using the entity group, and <c>clusterId</c> and <c>vpcId</c> are independent of each other.</para>
        /// </summary>
        [NameInMap("entityGroup")]
        [Validation(Required=false)]
        public CreateIntegrationPolicyRequestEntityGroup EntityGroup { get; set; }
        public class CreateIntegrationPolicyRequestEntityGroup : TeaModel {
            /// <summary>
            /// <para>Cluster entity type, such as acs.ack.cluster/acs.one.cluster/acs.asi.cluster or others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs.ack.cluster</para>
            /// </summary>
            [NameInMap("clusterEntityType")]
            [Validation(Required=false)]
            public string ClusterEntityType { get; set; }

            /// <summary>
            /// <para>Cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>na61prod3-na61cloudhdfsssd</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Whether to disable the unique binding of the Policy. If enabled, multiple Policies can be created for a single container cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ture</para>
            /// </summary>
            [NameInMap("disablePolicyShare")]
            [Validation(Required=false)]
            public bool? DisablePolicyShare { get; set; }

            /// <summary>
            /// <para>Entity group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eg-b79f65d11fb94e779867cf937c3a3002</para>
            /// </summary>
            [NameInMap("entityGroupId")]
            [Validation(Required=false)]
            public string EntityGroupId { get; set; }

            /// <summary>
            /// <para>User ID to which the cluster belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12xxxx</para>
            /// </summary>
            [NameInMap("entityUserId")]
            [Validation(Required=false)]
            public string EntityUserId { get; set; }

            /// <summary>
            /// <para>VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp18fgg3ffxa9czna40xt</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>Policy name</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-database</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>Policy type: CS/ECS/Cloud</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS</para>
        /// </summary>
        [NameInMap("policyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz2km4kmhtbii</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Resource tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateIntegrationPolicyRequestTags> Tags { get; set; }
        public class CreateIntegrationPolicyRequestTags : TeaModel {
            /// <summary>
            /// <para>Tag <c>key</c> value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>use</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag <c>value</c> value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prometheus</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}

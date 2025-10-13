// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreateIntegrationPolicyRequest : TeaModel {
        [NameInMap("entityGroup")]
        [Validation(Required=false)]
        public CreateIntegrationPolicyRequestEntityGroup EntityGroup { get; set; }
        public class CreateIntegrationPolicyRequestEntityGroup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acs.ack.cluster</para>
            /// </summary>
            [NameInMap("clusterEntityType")]
            [Validation(Required=false)]
            public string ClusterEntityType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>na61prod3-na61cloudhdfsssd</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("disablePolicyShare")]
            [Validation(Required=false)]
            public bool? DisablePolicyShare { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eg-b79f65d11fb94e779867cf937c3a3002</para>
            /// </summary>
            [NameInMap("entityGroupId")]
            [Validation(Required=false)]
            public string EntityGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-bp18fgg3ffxa9czna40xt</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>prod-database</para>
        /// </summary>
        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS</para>
        /// </summary>
        [NameInMap("policyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aekz2km4kmhtbii</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreateIntegrationPolicyRequestTags> Tags { get; set; }
        public class CreateIntegrationPolicyRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>use</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>prometheus</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}

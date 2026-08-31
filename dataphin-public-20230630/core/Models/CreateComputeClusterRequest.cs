// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateComputeClusterRequest : TeaModel {
        /// <summary>
        /// <para>The cluster configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ClusterConfig")]
        [Validation(Required=false)]
        public CreateComputeClusterRequestClusterConfig ClusterConfig { get; set; }
        public class CreateComputeClusterRequestClusterConfig : TeaModel {
            /// <summary>
            /// <para>The list of cluster administrator IDs.</para>
            /// </summary>
            [NameInMap("ClusterAdmins")]
            [Validation(Required=false)]
            public List<string> ClusterAdmins { get; set; }

            /// <summary>
            /// <para>The cluster security control configuration.</para>
            /// </summary>
            [NameInMap("ClusterSafetyControl")]
            [Validation(Required=false)]
            public CreateComputeClusterRequestClusterConfigClusterSafetyControl ClusterSafetyControl { get; set; }
            public class CreateComputeClusterRequestClusterConfigClusterSafetyControl : TeaModel {
                /// <summary>
                /// <para>The control mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE_COMPUTE_SOURCE</para>
                /// </summary>
                [NameInMap("ClusterSafetyAuthType")]
                [Validation(Required=false)]
                public string ClusterSafetyAuthType { get; set; }

                /// <summary>
                /// <para>The list of whitelist user group IDs.</para>
                /// </summary>
                [NameInMap("UserGroupIds")]
                [Validation(Required=false)]
                public List<string> UserGroupIds { get; set; }

                /// <summary>
                /// <para>The list of whitelist user IDs.</para>
                /// </summary>
                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

            /// <summary>
            /// <para>The connection configuration items.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public List<CreateComputeClusterRequestClusterConfigConfigList> ConfigList { get; set; }
            public class CreateComputeClusterRequestClusterConfigConfigList : TeaModel {
                /// <summary>
                /// <para>The configuration item.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the configuration item.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The cluster description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Des")]
            [Validation(Required=false)]
            public string Des { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster_test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The cluster type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The cluster version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CDH6</para>
            /// </summary>
            [NameInMap("TypeVersion")]
            [Validation(Required=false)]
            public string TypeVersion { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}

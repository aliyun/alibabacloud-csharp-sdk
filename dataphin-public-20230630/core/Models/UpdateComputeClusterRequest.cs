// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateComputeClusterRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ClusterConfig")]
        [Validation(Required=false)]
        public UpdateComputeClusterRequestClusterConfig ClusterConfig { get; set; }
        public class UpdateComputeClusterRequestClusterConfig : TeaModel {
            [NameInMap("ClusterAdmins")]
            [Validation(Required=false)]
            public List<string> ClusterAdmins { get; set; }

            [NameInMap("ClusterSafetyControl")]
            [Validation(Required=false)]
            public UpdateComputeClusterRequestClusterConfigClusterSafetyControl ClusterSafetyControl { get; set; }
            public class UpdateComputeClusterRequestClusterConfigClusterSafetyControl : TeaModel {
                /// <summary>
                /// <para>管控模式。CREATE_COMPUTE_SOURCE：有创建计算源权限即可使用；USER_DEFINE：仅白名单用户/用户组可用</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE_COMPUTE_SOURCE</para>
                /// </summary>
                [NameInMap("ClusterSafetyAuthType")]
                [Validation(Required=false)]
                public string ClusterSafetyAuthType { get; set; }

                [NameInMap("UserGroupIds")]
                [Validation(Required=false)]
                public List<string> UserGroupIds { get; set; }

                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public List<UpdateComputeClusterRequestClusterConfigConfigList> ConfigList { get; set; }
            public class UpdateComputeClusterRequestClusterConfigConfigList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
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
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Des")]
            [Validation(Required=false)]
            public string Des { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cluster_test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CDH6</para>
            /// </summary>
            [NameInMap("TypeVersion")]
            [Validation(Required=false)]
            public string TypeVersion { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102311</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ShrinkClusterRequest : TeaModel {
        /// <summary>
        /// <para>Cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i15dfa12e8f27c44f4a006c2c8bb</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Whether to allow skipping failed node tasks, default value is False</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        /// <summary>
        /// <para>Node group information</para>
        /// </summary>
        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<ShrinkClusterRequestNodeGroups> NodeGroups { get; set; }
        public class ShrinkClusterRequestNodeGroups : TeaModel {
            /// <summary>
            /// <para>Node group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-3b6fbd24b1b845a0</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>List of nodes</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ShrinkClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class ShrinkClusterRequestNodeGroupsNodes : TeaModel {
                /// <summary>
                /// <para>Node ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>e01poc-cn-zmb2ypjdc01</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

        }

    }

}

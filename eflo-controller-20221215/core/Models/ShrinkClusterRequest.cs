// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ShrinkClusterRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i15dfa12e8f27c44f4a006c2c8bb</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<ShrinkClusterRequestNodeGroups> NodeGroups { get; set; }
        public class ShrinkClusterRequestNodeGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ng-3b6fbd24b1b845a0</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ShrinkClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class ShrinkClusterRequestNodeGroupsNodes : TeaModel {
                /// <summary>
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

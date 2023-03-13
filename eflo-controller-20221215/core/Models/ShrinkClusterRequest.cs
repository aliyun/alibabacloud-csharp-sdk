// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ShrinkClusterRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("IgnoreFailedNodeTasks")]
        [Validation(Required=false)]
        public bool? IgnoreFailedNodeTasks { get; set; }

        [NameInMap("NodeGroups")]
        [Validation(Required=false)]
        public List<ShrinkClusterRequestNodeGroups> NodeGroups { get; set; }
        public class ShrinkClusterRequestNodeGroups : TeaModel {
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ShrinkClusterRequestNodeGroupsNodes> Nodes { get; set; }
            public class ShrinkClusterRequestNodeGroupsNodes : TeaModel {
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

            }

        }

    }

}

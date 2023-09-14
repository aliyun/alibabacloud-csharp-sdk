// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeSelector : TeaModel {
        /// <summary>
        /// 节点组ID。当NodeSelectType取值NodeGroup时，该参数生效。
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// 节点组名称。当NodeSelectType取值NodeGroup，且参数NodeGroupId为空时生效，该参数生效。
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// 节点组类型。当NodeSelectType取值NodeGroup，且参数NodeGroupId为空时生效。数组元数个数N取值范围：0~10。
        /// </summary>
        [NameInMap("NodeGroupTypes")]
        [Validation(Required=false)]
        public List<string> NodeGroupTypes { get; set; }

        /// <summary>
        /// 节点名称列表。当NodeSelectType取值Node时，该参数生效。
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// 节点选择类型。取值范围：
        /// - CLUSTER：集群。
        /// - NODE_GROUP：节点组。
        /// - NODE：节点。
        /// </summary>
        [NameInMap("NodeSelectType")]
        [Validation(Required=false)]
        public string NodeSelectType { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ComponentLayout : TeaModel {
        /// <summary>
        /// 应用名称。
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// 组件名称。
        /// </summary>
        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// 节点选择器。
        /// </summary>
        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public ComponentLayoutNodeSelector NodeSelector { get; set; }
        public class ComponentLayoutNodeSelector : TeaModel {
            /// <summary>
            /// 节点结束编号，包含结束编号。
            /// </summary>
            [NameInMap("NodeEndIndex")]
            [Validation(Required=false)]
            public int? NodeEndIndex { get; set; }

            /// <summary>
            /// 节点组ID。
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// 机器组下标编号。
            /// </summary>
            [NameInMap("NodeGroupIndex")]
            [Validation(Required=false)]
            public int? NodeGroupIndex { get; set; }

            /// <summary>
            /// 机器组名。
            /// </summary>
            [NameInMap("NodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

            /// <summary>
            /// SelectType = NODE_GROUP 且 nodeGroupId 不存在时使用
            /// </summary>
            [NameInMap("NodeGroupTypes")]
            [Validation(Required=false)]
            public List<string> NodeGroupTypes { get; set; }

            /// <summary>
            /// 节点名称列表。
            /// </summary>
            [NameInMap("NodeNames")]
            [Validation(Required=false)]
            public List<string> NodeNames { get; set; }

            /// <summary>
            /// 节点选择类型。
            /// </summary>
            [NameInMap("NodeSelectType")]
            [Validation(Required=false)]
            public string NodeSelectType { get; set; }

            /// <summary>
            /// 节点开始编号，包含开始编号。
            /// </summary>
            [NameInMap("NodeStartIndex")]
            [Validation(Required=false)]
            public int? NodeStartIndex { get; set; }

        }

    }

}

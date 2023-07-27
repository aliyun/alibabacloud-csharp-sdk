// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeNodesInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// The instance types of the nodes.
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<DescribeNodesInstanceTypeResponseBodyInstanceTypes> InstanceTypes { get; set; }
        public class DescribeNodesInstanceTypeResponseBodyInstanceTypes : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// Indicates whether the instance type supports Multi-Buffer acceleration. Valid values:
            /// 
            /// *   `true`
            /// *   `false`
            /// </summary>
            [NameInMap("MultiBufferEnabled")]
            [Validation(Required=false)]
            public bool? MultiBufferEnabled { get; set; }

            /// <summary>
            /// The instance type of the node.
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

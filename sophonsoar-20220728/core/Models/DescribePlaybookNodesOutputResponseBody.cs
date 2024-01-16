// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookNodesOutputResponseBody : TeaModel {
        /// <summary>
        /// The output data of the component node.
        /// </summary>
        [NameInMap("PlaybookNodesOutput")]
        [Validation(Required=false)]
        public DescribePlaybookNodesOutputResponseBodyPlaybookNodesOutput PlaybookNodesOutput { get; set; }
        public class DescribePlaybookNodesOutputResponseBodyPlaybookNodesOutput : TeaModel {
            /// <summary>
            /// The name of the component node.
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// The historical output data of the component node. The value is in the JSON string format. If no data is found, the parameter is left empty.
            /// </summary>
            [NameInMap("NodeOutput")]
            [Validation(Required=false)]
            public string NodeOutput { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

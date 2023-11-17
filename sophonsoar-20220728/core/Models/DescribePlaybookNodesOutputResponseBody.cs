// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookNodesOutputResponseBody : TeaModel {
        [NameInMap("PlaybookNodesOutput")]
        [Validation(Required=false)]
        public DescribePlaybookNodesOutputResponseBodyPlaybookNodesOutput PlaybookNodesOutput { get; set; }
        public class DescribePlaybookNodesOutputResponseBodyPlaybookNodesOutput : TeaModel {
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("NodeOutput")]
            [Validation(Required=false)]
            public string NodeOutput { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

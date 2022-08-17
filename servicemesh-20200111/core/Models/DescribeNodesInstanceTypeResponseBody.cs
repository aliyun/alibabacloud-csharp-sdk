// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeNodesInstanceTypeResponseBody : TeaModel {
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<DescribeNodesInstanceTypeResponseBodyInstanceTypes> InstanceTypes { get; set; }
        public class DescribeNodesInstanceTypeResponseBodyInstanceTypes : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("MultiBufferEnabled")]
            [Validation(Required=false)]
            public bool? MultiBufferEnabled { get; set; }

            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

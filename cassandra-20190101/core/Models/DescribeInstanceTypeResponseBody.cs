// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cassandra20190101.Models
{
    public class DescribeInstanceTypeResponseBody : TeaModel {
        [NameInMap("InstanceTypeSpecList")]
        [Validation(Required=false)]
        public DescribeInstanceTypeResponseBodyInstanceTypeSpecList InstanceTypeSpecList { get; set; }
        public class DescribeInstanceTypeResponseBodyInstanceTypeSpecList : TeaModel {
            [NameInMap("InstanceTypeSpec")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypeResponseBodyInstanceTypeSpecListInstanceTypeSpec> InstanceTypeSpec { get; set; }
            public class DescribeInstanceTypeResponseBodyInstanceTypeSpecListInstanceTypeSpec : TeaModel {
                [NameInMap("CpuSize")]
                [Validation(Required=false)]
                public long? CpuSize { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("MemSize")]
                [Validation(Required=false)]
                public long? MemSize { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

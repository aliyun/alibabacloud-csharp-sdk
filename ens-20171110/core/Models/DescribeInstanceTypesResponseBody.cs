// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceTypesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                [NameInMap("InstanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                [NameInMap("InstanceTypeName")]
                [Validation(Required=false)]
                public string InstanceTypeName { get; set; }

                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

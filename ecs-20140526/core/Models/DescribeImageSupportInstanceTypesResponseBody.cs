// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageSupportInstanceTypesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<DescribeImageSupportInstanceTypesResponseBodyInstanceTypes> InstanceTypes { get; set; }
        public class DescribeImageSupportInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceTypeId")]
            [Validation(Required=false)]
            public string InstanceTypeId { get; set; }

            [NameInMap("InstanceTypeFamily")]
            [Validation(Required=false)]
            public string InstanceTypeFamily { get; set; }

            [NameInMap("CpuCoreCount")]
            [Validation(Required=false)]
            public int? CpuCoreCount { get; set; }

            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public float? MemorySize { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageSupportInstanceTypesResponseBody : TeaModel {
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeImageSupportInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeImageSupportInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeImageSupportInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeImageSupportInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                public int? CpuCoreCount { get; set; }
                public string InstanceTypeFamily { get; set; }
                public string InstanceTypeId { get; set; }
                public float? MemorySize { get; set; }
            }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

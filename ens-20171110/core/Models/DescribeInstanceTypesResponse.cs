// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceTypesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=true)]
        public DescribeInstanceTypesResponseInstanceTypes InstanceTypes { get; set; }
        public class DescribeInstanceTypesResponseInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=true)]
            public List<DescribeInstanceTypesResponseInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeInstanceTypesResponseInstanceTypesInstanceType : TeaModel {
                public int? CpuCoreCount { get; set; }
                public int? MemorySize { get; set; }
                public string InstanceTypeId { get; set; }
                public string InstanceTypeName { get; set; }
            }
        };

    }

}

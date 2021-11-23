// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class DescribeInstanceTypesResponseBody : TeaModel {
        /// <summary>
        /// Array of InstanceType
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<DescribeInstanceTypesResponseBodyInstanceTypes> InstanceTypes { get; set; }
        public class DescribeInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("CpuCoreCount")]
            [Validation(Required=false)]
            public float? CpuCoreCount { get; set; }

            [NameInMap("InstanceTypeDescription")]
            [Validation(Required=false)]
            public string InstanceTypeDescription { get; set; }

            [NameInMap("InstanceTypeId")]
            [Validation(Required=false)]
            public string InstanceTypeId { get; set; }

            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public float? MemorySize { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

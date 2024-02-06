// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeInstanceTypesResponseBody : TeaModel {
        /// <summary>
        /// The status code. If the request is successful, 0 is returned. If the request fails, a non-zero error code is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// Details about the instance types.
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                /// <summary>
                /// The number of vCPUs.
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// This parameter is unavailable.
                /// </summary>
                [NameInMap("InstanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                /// <summary>
                /// The name of the instance type.
                /// </summary>
                [NameInMap("InstanceTypeName")]
                [Validation(Required=false)]
                public string InstanceTypeName { get; set; }

                /// <summary>
                /// The memory size. Unit: MB.
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

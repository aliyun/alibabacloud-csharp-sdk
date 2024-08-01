// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageSupportInstanceTypesResponseBody : TeaModel {
        /// <summary>
        /// The key of filter N. Only the image ID can be used to filter instance types. Valid values:
        /// 
        /// *   imagId: image ID
        /// *   filter: image ID
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// {
        ///     "RequestId": "CF661E2D-4AFE-4BCD-959A-A65E14416B44",
        ///     "RegionId": "cn-hangzhou",
        ///     "ImageId": "ubuntu_16_0402_64_20G_alibase_20180409.vhd",
        ///     "InstanceTypes": {
        ///         "InstanceType": [{
        ///             "InstanceTypeId": "ecs.t1.xsmall",
        ///             "CpuCoreCount": 1,
        ///             "MemorySize": 0.5,
        ///             "InstanceTypeFamily": "ecs.t1"
        ///         },
        ///         {
        ///             "InstanceTypeId": "ecs.t1.small",
        ///             "CpuCoreCount": 1,
        ///             "MemorySize": 1,
        ///             "InstanceTypeFamily": "ecs.t1"
        ///         }]
        ///     }
        /// }
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeImageSupportInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeImageSupportInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeImageSupportInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeImageSupportInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                /// <summary>
                /// The number of vCPUs of the instance type.
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// DescribeImageSupportInstanceTypes
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// Queries the instance types supported by an image.
                /// </summary>
                [NameInMap("InstanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                /// <summary>
                /// The memory size of the instance type. Unit: GiB.
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public float? MemorySize { get; set; }

            }

        }

        /// <summary>
        /// {
        ///     "RequestId": "CF661E2D-4AFE-4BCD-959A-A65E14416B44",
        ///     "RegionId": "cn-hangzhou",
        ///     "ImageId": "ubuntu_16_0402_64_20G_alibase_20180409.vhd",
        ///     "InstanceTypes": {
        ///         "InstanceType": [{
        ///             "InstanceTypeId": "ecs.t1.xsmall",
        ///             "CpuCoreCount": 1,
        ///             "MemorySize": 0.5,
        ///             "InstanceTypeFamily": "ecs.t1"
        ///         },
        ///         {
        ///             "InstanceTypeId": "ecs.t1.small",
        ///             "CpuCoreCount": 1,
        ///             "MemorySize": 1,
        ///             "InstanceTypeFamily": "ecs.t1"
        ///         }]
        ///     }
        /// }
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesRequest : TeaModel {
        /// <summary>
        /// The applicable scope of the desktop type. Default value: `Public`.
        /// </summary>
        [NameInMap("AppliedScope")]
        [Validation(Required=false)]
        public string AppliedScope { get; set; }

        /// <summary>
        /// The number of vCPUs.
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// The ID of the cloud desktop whose desktop type that you want to modify. If you specify this parameter, the information that is returned includes whether the desktop type is compatible with the cloud desktop.
        /// </summary>
        [NameInMap("DesktopIdForModify")]
        [Validation(Required=false)]
        public string DesktopIdForModify { get; set; }

        /// <summary>
        /// The ID of the desktop type. Valid values:
        /// 
        /// *   eds.graphics.16c1t4
        /// *   eds.graphics.24c1t4
        /// *   eds.hf.12c24g
        /// *   eds.hf.8c16g
        /// *   eds.hf.4c8g
        /// *   eds.general.8c32g
        /// *   eds.general.16c32g
        /// *   eds.general.8c16g
        /// *   eds.general.4c16g
        /// *   eds.general.4c8g
        /// *   eds.general.2c8g
        /// *   eds.general.2c4g
        /// *   eds.general.2c2g
        /// *   ecd.graphics.xlarge
        /// *   ecd.graphics.2xlarge
        /// *   ecd.performance.2xlarge
        /// *   ecd.advanced.xlarge
        /// *   ecd.advanced.large
        /// *   ecd.basic.large
        /// *   ecd.basic.small
        /// 
        /// > When no values are specified for the `InstanceTypeFamily` and `DesktopTypeId` parameters for a cloud desktop, all desktop types are queried.
        /// </summary>
        [NameInMap("DesktopTypeId")]
        [Validation(Required=false)]
        public string DesktopTypeId { get; set; }

        /// <summary>
        /// The number of GPUs.
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public float? GpuCount { get; set; }

        /// <summary>
        /// The family of the cloud desktop type. Valid values:
        /// 
        /// *   eds.graphics
        /// *   eds.hf
        /// *   eds.general
        /// *   ecd.graphics
        /// *   ecd.performance
        /// *   ecd.advanced
        /// *   ecd.basic
        /// 
        /// > When no values are specified for the `InstanceTypeFamily` and `DesktopTypeId` parameters for a cloud desktop, all desktop types are queried.
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// The size of the memory. Unit: GiB.
        /// </summary>
        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// The type of the order that you want to place.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

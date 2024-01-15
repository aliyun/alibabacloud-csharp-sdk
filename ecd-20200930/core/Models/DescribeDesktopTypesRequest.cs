// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopTypesRequest : TeaModel {
        /// <summary>
        /// Applicable Scope of specifications. Default value: `Public`
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

        [NameInMap("DesktopGroupIdForModify")]
        [Validation(Required=false)]
        public string DesktopGroupIdForModify { get; set; }

        /// <summary>
        /// When changing the configuration, enter the desktop ID that needs to be changed. The return value will increase the compatibility between the specifications and the desktop.
        /// </summary>
        [NameInMap("DesktopIdForModify")]
        [Validation(Required=false)]
        public string DesktopIdForModify { get; set; }

        /// <summary>
        /// The ID of the cloud desktop type. Valid values:
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
        /// </summary>
        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        /// <summary>
        /// The memory size. Unit: GiB.
        /// </summary>
        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// The order type.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

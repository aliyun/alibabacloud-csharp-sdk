// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ReplaceBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// The GA instance ID.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The ID of the required bandwidth plan. When you specify a replacement bandwidth plan, take note of the following items:
        /// 
        /// *   Only a bandwidth plan that is not associated with a GA instance can be specified.
        /// *   If you want to replace a basic bandwidth plan, make sure that the bandwidth provided by the replacement bandwidth plan is not less than the total bandwidth allocated to the acceleration area.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the bandwidth plan that you want to replace.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetBandwidthPackageId")]
        [Validation(Required=false)]
        public string TargetBandwidthPackageId { get; set; }

    }

}

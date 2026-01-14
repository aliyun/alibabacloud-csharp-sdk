// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ReplaceBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>The GA instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The ID of the required bandwidth plan. When you specify a replacement bandwidth plan, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Only a bandwidth plan that is not associated with a GA instance can be specified.</description></item>
        /// <item><description>If you want to replace a basic bandwidth plan, make sure that the bandwidth provided by the replacement bandwidth plan is not less than the total bandwidth allocated to the acceleration area.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbwp-bp176neb61yhcymow****</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The region ID of the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the bandwidth plan that you want to replace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbwp-o978hgeb61yhcymow****</para>
        /// </summary>
        [NameInMap("TargetBandwidthPackageId")]
        [Validation(Required=false)]
        public string TargetBandwidthPackageId { get; set; }

    }

}

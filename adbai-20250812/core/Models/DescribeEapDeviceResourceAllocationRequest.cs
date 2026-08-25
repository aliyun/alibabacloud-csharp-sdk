// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class DescribeEapDeviceResourceAllocationRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The total number of devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DeviceCount")]
        [Validation(Required=false)]
        public int? DeviceCount { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <remarks>
        /// <para>You can call the DescribeRegions operation to query the region ID of a specified Data Lakehouse Edition cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

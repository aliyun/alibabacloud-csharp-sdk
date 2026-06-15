// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeEipMonitorDataRequest : TeaModel {
        /// <summary>
        /// <para>The allocation ID of the EIP.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The end of the query time range, in UTC. Specify the time in the ISO 8601 format: <c>YYYY-MM-DDThh:mm:ssZ</c>. The end time must be later than <c>StartTime</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The aggregation period for monitoring data, in seconds. Valid values: 60, 300, and 900.</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The region ID of the Elastic IP Address (EIP). You can call the <c>DescribeRegions</c> operation to get the latest list of regions.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start of the query time range, in UTC. Specify the time in the ISO 8601 format: <c>YYYY-MM-DDThh:mm:ssZ</c>. The start time must be within the past 30 days and earlier than <c>EndTime</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

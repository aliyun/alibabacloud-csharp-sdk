// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class StopDiskMonitorRequest : TeaModel {
        /// <summary>
        /// The IDs of the disks for which you want to disable near real-time monitoring.
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public List<string> DiskIds { get; set; }

        /// <summary>
        /// The ID of the region in which you want to disable near real-time monitoring for disks. You can call the [DescribeRegions](~~354276~~) operation to query the list of regions that support CloudLens for EBS.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

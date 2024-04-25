// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeLensMonitorDisksRequest : TeaModel {
        /// <summary>
        /// The type of the disk. Valid values:
        /// - cloud
        /// - cloud_efficiency
        /// - cloud_ssd
        /// - cloud_essd
        /// - cloud_auto
        /// - cloud_essd_entry
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The list of disks.
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public List<string> DiskIds { get; set; }

        /// <summary>
        /// Lens event tag list to filter cloud disks that have experienced these event types within 24 hours. Valid values:
        /// 
        /// - NoSnapshot
        /// - BurstIOTriggered
        /// - CostOptimizationNeeded
        /// - DiskSpecNotMatchedWithInstance
        /// - DiskIONo4kAligned
        /// - DiskIOHang
        /// - InstanceIOPSExceedInstanceMaxLimit
        /// - InstanceBPSExceedInstanceMaxLimit
        /// - DiskIOPSExceedInstanceMaxLimit
        /// - DiskBPSExceedInstanceMaxLimit
        /// - DiskIOPSExceedDiskMaxLimit
        /// - DiskBPSExceedDiskMaxLimit
        /// - DiskSlowIOTriggerred
        /// </summary>
        [NameInMap("LensTags")]
        [Validation(Required=false)]
        public List<string> LensTags { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 100. Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token used to start the next query to retrieve more results.
        /// 
        /// >  This parameter is not required in the first query. If not all results are returned in one query, you can pass in the NextToken value returned in the previous query to perform the query again.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

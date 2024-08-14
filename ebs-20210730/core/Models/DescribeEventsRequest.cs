// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEventsRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the event. Valid values:
        /// 
        /// *   NoSnapshot: indicates the event that is triggered because no snapshot is created for a disk to protect data on the disk.
        /// *   BurstIOTriggered: indicates the event that is triggered when a burst I/O operation is performed on a disk.
        /// *   CostOptimizationNeeded: indicates the event that is triggered when cost optimization is required.
        /// *   DiskSpecNotMatchedWithInstance: indicates the event that is triggered because the specifications of a disk do not match the instance to which the disk is attached.
        /// *   DiskIONo4kAligned: indicates the event that is triggered because the physical and logical sectors involved in a read or write operation are not 4K aligned.
        /// *   DiskIOHang: indicates the event that is triggered when an I/O hang occurs on a disk.
        /// *   InstanceIOPSExceedInstanceMaxLimit: indicates the event that is triggered when the number of IOPS on an instance reaches the upper limit.
        /// *   InstanceBPSExceedInstanceMaxLimit: indicates the event that is triggered when the number of BPS on an instance reaches the upper limit.
        /// *   DiskIOPSExceedInstanceMaxLimit: indicates the event that is triggered when the number of IOPS on a disk reaches the upper limit for the associated instance.
        /// *   DiskBPSExceedInstanceMaxLimit: indicates the event that is triggered when the number of BPS on a disk reaches the upper limit for the associated instance.
        /// *   DiskIOPSExceedDiskMaxLimit: indicates the event that is triggered when the number of IOPS on a disk reaches the upper limit for the disk.
        /// *   DiskBPSExceedDiskMaxLimit: indicates the event that is triggered when the number of BPS on a disk reaches the upper limit for the disk.
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// The maximum number of entries per page. If you specify MaxResults, `MaxResults` and `NextToken` are used for a paged query.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID . You can call the [DescribeRegions](https://help.aliyun.com/document_detail/354276.html) operation to query the most recent list of regions supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource ID.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of resource. Valid values:
        /// 
        /// *   disk.
        /// 
        /// Default value: disk.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of event. Valid values:
        /// 
        /// - WillExecute
        /// - Executing
        /// - Executed
        /// - Ignore
        /// - Expired
        /// - Deleted
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

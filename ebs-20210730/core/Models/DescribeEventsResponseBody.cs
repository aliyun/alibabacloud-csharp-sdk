// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The events.
        /// </summary>
        [NameInMap("ResourceEvents")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyResourceEvents> ResourceEvents { get; set; }
        public class DescribeEventsResponseBodyResourceEvents : TeaModel {
            /// <summary>
            /// The description of the event.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The end time of the event, expressed as the number of milliseconds after Jan 1, 1970 00:00:00 UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The level of the event. Valid values:
            /// 
            /// 1.  INFO
            /// 2.  WARN
            /// 3.  CRITICAL
            /// </summary>
            [NameInMap("EventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

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
            /// The type of the event. Valid values:
            /// 
            /// 1.  Notification
            /// 2.  SystemException
            /// 3.  Alert
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The recommended action after the event occurred. Valid values:
            /// 
            /// *   ModifyDiskSpec
            /// *   CreateSnapshot
            /// *   ResizeDisk
            /// *   AdjustProvision
            /// *   ModifyInstanceSpec
            /// </summary>
            [NameInMap("RecommendAction")]
            [Validation(Required=false)]
            public string RecommendAction { get; set; }

            /// <summary>
            /// The codes of the parameters for the recommended action after the event occurred.
            /// </summary>
            [NameInMap("RecommendParams")]
            [Validation(Required=false)]
            public string RecommendParams { get; set; }

            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The type of the resource.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The start time of the event, expressed as the number of milliseconds after Jan 1, 1970 00:00:00 UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the event. Valid values:
            /// 
            /// 1.  WillExecute
            /// 2.  Executing
            /// 3.  Executed
            /// 4.  Ignore
            /// 5.  Expired
            /// 6.  Deleted
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

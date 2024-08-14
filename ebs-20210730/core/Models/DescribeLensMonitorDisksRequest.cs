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
        /// Event tags of the disk, which are used to filter the disks on which the events associated with the specified tags occurred in the previous 24 hours. Valid values:
        /// 
        /// *   NoSnapshot: specifies the event that is triggered because no snapshot is created for the disk to protect data on the disk.
        /// *   BurstIOTriggered: specifies the event that is triggered when a burst I/O operation is performed on the disk.
        /// *   CostOptimizationNeeded: specifies the event that is triggered when cost optimization is required.
        /// *   DiskSpecNotMatchedWithInstance: specifies the event that is triggered if the disk specifications do not match the instance to which the disk is attached.
        /// *   DiskIONo4kAligned: specifies the event that is triggered if the physical and logical sectors involved in a read or write operation are not 4K aligned.
        /// *   DiskIOHang: specifies the event that is triggered when an I/O hang occurs on the disk.
        /// *   InstanceIOPSExceedInstanceMaxLimit: specifies the event that is triggered when the number of IOPS on the instance reaches the upper limit.
        /// *   InstanceBPSExceedInstanceMaxLimit: specifies the event that is triggered when the number of BPS on the instance reaches the upper limit.
        /// *   DiskIOPSExceedInstanceMaxLimit: specifies the event that is triggered when the number of IOPS on the disk reaches the upper limit of the instance.
        /// *   DiskBPSExceedInstanceMaxLimit: specifies the event that is triggered when the number of BPS on the disk reaches the upper limit of the instance.
        /// *   DiskIOPSExceedDiskMaxLimit: specifies the event that is triggered when the number of IOPS on the disk reaches the upper limit of the disk.
        /// *   DiskBPSExceedDiskMaxLimit: specifies the event that is triggered when the number of BPS on the disk reaches the upper limit of the disk.
        /// *   DiskSlowIOTriggerred: specifies the event that is triggered when the I/O speed on the disk is slow.
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
        /// >The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

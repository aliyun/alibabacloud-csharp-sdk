// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDedicatedClusterResponseBody : TeaModel {
        /// <summary>
        /// The CPU utilization. Unit: percentage.
        /// </summary>
        [NameInMap("CpuUtilization")]
        [Validation(Required=false)]
        public long? CpuUtilization { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// The name of the cluster.
        /// </summary>
        [NameInMap("DedicatedClusterName")]
        [Validation(Required=false)]
        public string DedicatedClusterName { get; set; }

        /// <summary>
        /// The disk usage.
        /// </summary>
        [NameInMap("DiskUtilization")]
        [Validation(Required=false)]
        public long? DiskUtilization { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DtsInstanceID")]
        [Validation(Required=false)]
        public string DtsInstanceID { get; set; }

        /// <summary>
        /// The number of DTS units (DUs).
        /// </summary>
        [NameInMap("Du")]
        [Validation(Required=false)]
        public long? Du { get; set; }

        /// <summary>
        /// The DU usage. Unit: percentage.
        /// </summary>
        [NameInMap("DuUtilization")]
        [Validation(Required=false)]
        public long? DuUtilization { get; set; }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The time when the cluster was created.
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        /// <summary>
        /// The time when the cluster stopped.
        /// </summary>
        [NameInMap("GmtFinished")]
        [Validation(Required=false)]
        public long? GmtFinished { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// The memory usage.
        /// </summary>
        [NameInMap("MemUtilization")]
        [Validation(Required=false)]
        public long? MemUtilization { get; set; }

        /// <summary>
        /// The number of nodes in the cluster.
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public long? NodeCount { get; set; }

        /// <summary>
        /// The number of DUs that exceeds the upper limit.
        /// </summary>
        [NameInMap("OversoldDu")]
        [Validation(Required=false)]
        public long? OversoldDu { get; set; }

        /// <summary>
        /// The ID of the region in which the instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the cluster. Valid values:
        /// 
        /// *   **init**: The cluster is being initialized.
        /// *   **schedule**: The cluster is pending scheduling.
        /// *   **running**: The cluster is running.
        /// *   **upgrade**: The cluster is being upgraded.
        /// *   **downgrade**: The cluster is being downgraded.
        /// *   **locked**: The cluster is locked.
        /// *   **releasing**: The cluster is being released.
        /// *   **released**: The cluster is released.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The total number of CPU cores.
        /// </summary>
        [NameInMap("TotalCpuCore")]
        [Validation(Required=false)]
        public long? TotalCpuCore { get; set; }

        /// <summary>
        /// The total disk size. Unit: GB.
        /// </summary>
        [NameInMap("TotalDiskGBSize")]
        [Validation(Required=false)]
        public long? TotalDiskGBSize { get; set; }

        /// <summary>
        /// The total amount of memory. Unit: GB.
        /// </summary>
        [NameInMap("TotalMemGBSize")]
        [Validation(Required=false)]
        public long? TotalMemGBSize { get; set; }

        /// <summary>
        /// The number of used CPU cores.
        /// </summary>
        [NameInMap("UsedCpuCore")]
        [Validation(Required=false)]
        public long? UsedCpuCore { get; set; }

        /// <summary>
        /// The used disk size. Unit: GB.
        /// </summary>
        [NameInMap("UsedDiskGBSize")]
        [Validation(Required=false)]
        public long? UsedDiskGBSize { get; set; }

        /// <summary>
        /// The number of used DUs.
        /// </summary>
        [NameInMap("UsedDu")]
        [Validation(Required=false)]
        public long? UsedDu { get; set; }

        /// <summary>
        /// The amount of used memory. Unit: GB.
        /// </summary>
        [NameInMap("UsedMemGBSize")]
        [Validation(Required=false)]
        public long? UsedMemGBSize { get; set; }

    }

}

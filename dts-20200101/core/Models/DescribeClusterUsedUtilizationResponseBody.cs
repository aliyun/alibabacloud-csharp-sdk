// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeClusterUsedUtilizationResponseBody : TeaModel {
        /// <summary>
        /// The error code returned by the backend service. The number is incremented.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The CPU utilization of the cluster. Unit: percentage.
        /// </summary>
        [NameInMap("CpuTotal")]
        [Validation(Required=false)]
        public float? CpuTotal { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        /// <summary>
        /// The total disk size of the cluster. Unit: GB.
        /// </summary>
        [NameInMap("DiskTotal")]
        [Validation(Required=false)]
        public float? DiskTotal { get; set; }

        /// <summary>
        /// The disk usage of the cluster. Unit: GB.
        /// </summary>
        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public float? DiskUsed { get; set; }

        /// <summary>
        /// The total number of DTS units (DUs).
        /// </summary>
        [NameInMap("DuTotal")]
        [Validation(Required=false)]
        public int? DuTotal { get; set; }

        /// <summary>
        /// The usage of DUs.
        /// </summary>
        [NameInMap("DuUsed")]
        [Validation(Required=false)]
        public int? DuUsed { get; set; }

        /// <summary>
        /// The dynamic part in the error message. This parameter is used to replace %s in the ErrMessage parameter.
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

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
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The total amount of memory. A value of 0 is temporarily returned.
        /// </summary>
        [NameInMap("MemoryTotal")]
        [Validation(Required=false)]
        public float? MemoryTotal { get; set; }

        /// <summary>
        /// The memory usage. A value of 0 is temporarily returned.
        /// </summary>
        [NameInMap("MemoryUsed")]
        [Validation(Required=false)]
        public float? MemoryUsed { get; set; }

        /// <summary>
        /// The memory usage.
        /// </summary>
        [NameInMap("MemoryUsedPercentage")]
        [Validation(Required=false)]
        public float? MemoryUsedPercentage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The number of tasks that are in progress.
        /// </summary>
        [NameInMap("TaskRunning")]
        [Validation(Required=false)]
        public int? TaskRunning { get; set; }

    }

}

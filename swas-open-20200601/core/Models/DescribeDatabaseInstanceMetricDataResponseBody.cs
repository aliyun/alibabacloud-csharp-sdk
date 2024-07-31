// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeDatabaseInstanceMetricDataResponseBody : TeaModel {
        /// <summary>
        /// The data format. Valid values:
        /// 
        /// *   cpuusage\\&memusage
        /// *   active_session\\&total_session
        /// *   ins_size\\&data_size\\&log_size\\&tmp_size\\&other_size
        /// *   io
        /// </summary>
        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// The monitoring data.
        /// </summary>
        [NameInMap("MetricData")]
        [Validation(Required=false)]
        public string MetricData { get; set; }

        /// <summary>
        /// The name of the metric. Valid values:
        /// 
        /// *   MySQL_MemCpuUsage: The CPU utilization and memory usage of the instance within the entire operating system.
        /// *   MySQL_DetailedSpaceUsage: The total space usage, data space, log space, temporary space, and system space of the instance.
        /// *   MySQL_Sessions : The total number of active connections.
        /// *   MySQL_IOPS: The IOPS of the instance.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The unit of the monitoring metric.
        /// 
        /// *   %
        /// *   int
        /// *   MB
        /// </summary>
        [NameInMap("Unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}

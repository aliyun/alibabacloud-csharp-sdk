// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBInstanceMetricsRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// The keys of the Enhanced Monitoring metrics that you want to display for the instance. You can enter a maximum of 30 metric keys. If you enter multiple metric keys, you must separate the metric keys with commas (,).
        /// 
        /// You can call the DescribeAvailableMetrics operation to query the keys of metrics.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricsConfig")]
        [Validation(Required=false)]
        public string MetricsConfig { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The application scope of this modification. Valid values:
        /// 
        /// *   **instance**: This modification is applied only to the current instance.
        /// *   **region**: This modification is applied to all ApsaraDB RDS for PostgreSQL instances that are equipped with the same type of storage media as the current instance in the region to which the current instance belongs. For example, if the current instance is equipped with cloud disks, this modification is applied to all ApsaraDB RDS for PostgreSQL instances that are equipped with cloud disks in the region to which the current instance belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}

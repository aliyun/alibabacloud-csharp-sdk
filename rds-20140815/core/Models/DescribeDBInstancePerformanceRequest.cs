// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancePerformanceRequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the DescribeDBInstances operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC.
        /// 
        /// >  The time span between the beginning time and the end time must be longer than the monitoring frequency. Otherwise, this operation may return an empty array.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The performance metrics that you want to query. Separate multiple values with commas (,). You can specify up to 30 values. For more information, see [Performance parameters](~~26316~~).
        /// 
        /// >  If you set **Key** to **MySQL_SpaceUsage** or **SQLServer_SpaceUsage**, you can query the monitoring data within only one day.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm*Z format. The time must be in UTC.
        /// 
        /// >  The time span between the beginning time and the end time must be longer than the monitoring frequency. Otherwise, this operation may return an empty array.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

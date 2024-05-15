// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceSqlOptimizeStatisticRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Specifies whether to filter instances for which DAS Enterprise Edition is enabled. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// >  If you set this parameter to **true**, only database instances for which DAS Enterprise Edition is disabled are queried. If you set this parameter to **false**, all database instances are queried.
        /// </summary>
        [NameInMap("FilterEnable")]
        [Validation(Required=false)]
        public string FilterEnable { get; set; }

        /// <summary>
        /// The database instance ID.
        /// 
        /// >  The database instance must be an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The node ID.
        /// 
        /// >  For ApsaraDB RDS for MySQL Cluster Edition instances or PolarDB for MySQL clusters, you must specify the node ID.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The duration threshold for automatic SQL optimization events. After this parameter is specified, the system collects statistics on automatic SQL optimization events whose duration does not exceed the specified threshold.
        /// 
        /// >  This parameter is a reserved parameter and does not take effect.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

        /// <summary>
        /// Specifies whether to merge automatic SQL optimization events. Valid values:
        /// 
        /// *   **true**: merges automatic SQL optimization events.
        /// *   **false**: does not merge automatic SQL optimization events.
        /// 
        /// >  This parameter is a reserved parameter and does not take effect.
        /// </summary>
        [NameInMap("UseMerging")]
        [Validation(Required=false)]
        public string UseMerging { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAutonomousNotifyEventsInRangeRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// 
        /// >  The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("EventContext")]
        [Validation(Required=false)]
        public string EventContext { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The urgency level of the events. If you specify this parameter, the MinLevel parameter does not take effect. Valid values:
        /// 
        /// *   **Notice**: events for which the system sends notifications.
        /// *   **Optimization**: events that need to be optimized.
        /// *   **Warn**: events for which the system sends warnings.
        /// *   **Critical**: critical events.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The minimum urgency level of the events. Valid values:
        /// 
        /// *   **Notice**: events for which the system sends notifications.
        /// *   **Optimization**: events that need to be optimized.
        /// *   **Warn**: events for which the system sends warnings.
        /// *   **Critical**: critical events.
        /// </summary>
        [NameInMap("MinLevel")]
        [Validation(Required=false)]
        public string MinLevel { get; set; }

        /// <summary>
        /// The ID of the node in a PolarDB for MySQL cluster. You can call the [DescribeDBClusters](~~98094~~) operation to query the node ID returned by the DBNodeId response parameter.
        /// 
        /// >  You must specify the node ID if your database instance is a PolarDB for MySQL cluster.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The page number. The value must be a positive integer. Default value: 1.
        /// </summary>
        [NameInMap("PageOffset")]
        [Validation(Required=false)]
        public string PageOffset { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The reserved parameter.
        /// </summary>
        [NameInMap("__context")]
        [Validation(Required=false)]
        public string Context { get; set; }

    }

}

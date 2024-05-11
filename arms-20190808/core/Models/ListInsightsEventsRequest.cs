// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListInsightsEventsRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value is a timestamp.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The types of the events that you want to query. Separate multiple event types with commas (,). If you do not specify this parameter, all events are queried.
        /// 
        /// *   errorIncrease: API error-rate spike events. Examples: HTTP API error-rate spike events and Dubbo API error-rate spike events.
        /// *   topErrorIncrease: the top five API error-rate spike events with the highest traffic.
        /// *   topRtIncrease: API response-time spike events. Examples: HTTP API response-time spike events and Dubbo API response-time spike events.
        /// *   rtIncrease: the top five API response-time spike events with the highest traffic.
        /// </summary>
        [NameInMap("InsightsTypes")]
        [Validation(Required=false)]
        public string InsightsTypes { get; set; }

        /// <summary>
        /// The ID of the application.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The start of the time range to query. The value is a timestamp.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

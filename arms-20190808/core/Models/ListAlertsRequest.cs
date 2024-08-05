// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAlertsRequest : TeaModel {
        /// <summary>
        /// The name of the alert rule.
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// The ID of the notification policy.
        /// </summary>
        [NameInMap("DispatchRuleId")]
        [Validation(Required=false)]
        public long? DispatchRuleId { get; set; }

        /// <summary>
        /// The end time of the alert sending history that you want to query. Specify the time in the `YYYY-MM-DD HH:mm:ss` format.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The integration type.
        /// 
        /// *   ARMS
        /// *   CLOUD_MONITOR
        /// *   MSE
        /// *   ARMS_CLOUD_DIALTEST
        /// *   PROMETHEUS
        /// *   LOG_SERVICE
        /// *   CUSTOM
        /// *   ARMS_PROMETHEUS
        /// *   ARMS_APP_MON
        /// *   ARMS_FRONT_MON
        /// *   ARMS_CUSTOM
        /// *   XTRACE
        /// *   GRAFANA
        /// *   ZABBIX
        /// *   SKYWALKING
        /// *   EVENT_BRIDGE
        /// *   NAGIOS
        /// *   OPENFALCON
        /// *   ARMS_INSIGHTS
        /// </summary>
        [NameInMap("IntegrationType")]
        [Validation(Required=false)]
        public string IntegrationType { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The severity level of the alert. Valid values: P6, P5, P4, P3, P2, and P1. The preceding values are listed in ascending order of severity.
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// Specifies whether to query the activities that correspond to alerts. Valid values:
        /// 
        /// *   `false` (default value): The activities are not queried.
        /// *   `true`: The activities in the last three days are queried.
        /// </summary>
        [NameInMap("ShowActivities")]
        [Validation(Required=false)]
        public bool? ShowActivities { get; set; }

        /// <summary>
        /// Specifies whether to query the events that correspond to alerts. Valid values:
        /// 
        /// *   `false` (default value): The events are not queried.
        /// *   `true`: The events are queried.
        /// </summary>
        [NameInMap("ShowEvents")]
        [Validation(Required=false)]
        public bool? ShowEvents { get; set; }

        /// <summary>
        /// The number of alerts to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// The start time of the alert sending history that you want to query. Specify the time in the `YYYY-MM-DD HH:mm:ss` format.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The status of the alert. Valid values:
        /// 
        /// *   0: The alert is pending.
        /// *   1: The alert is being handled.
        /// *   2: The alert is handled.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public long? State { get; set; }

    }

}

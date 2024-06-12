// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeAlarmsRequest : TeaModel {
        /// <summary>
        /// The ID of the event-triggered task.
        /// </summary>
        [NameInMap("AlarmTaskId")]
        [Validation(Required=false)]
        public string AlarmTaskId { get; set; }

        /// <summary>
        /// Specifies whether to enable the event-triggered task. Valid values:
        /// 
        /// *   true: enables the event-triggered task.
        /// *   false: disables the event-triggered task.
        /// </summary>
        [NameInMap("IsEnable")]
        [Validation(Required=false)]
        public bool? IsEnable { get; set; }

        /// <summary>
        /// The metric name.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The metric type. Valid values:
        /// 
        /// *   system: system metrics of CloudMonitor
        /// *   custom: custom metrics that are reported to CloudMonitor.
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the event-triggered task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group with which the event-triggered task is associated.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The status of the event-triggered task. Valid values:
        /// 
        /// *   ALARM: The alert condition is met and an alert is triggered.
        /// *   OK: The alert condition is not met.
        /// *   INSUFFICIENT_DATA: Auto Scaling cannot determine whether the alert condition is met due to insufficient data.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}

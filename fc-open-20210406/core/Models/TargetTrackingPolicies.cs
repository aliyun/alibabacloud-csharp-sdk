// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class TargetTrackingPolicies : TeaModel {
        /// <summary>
        /// endTime
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// maxCapacity
        /// </summary>
        [NameInMap("maxCapacity")]
        [Validation(Required=false)]
        public long? MaxCapacity { get; set; }

        /// <summary>
        /// metricTarget
        /// </summary>
        [NameInMap("metricTarget")]
        [Validation(Required=false)]
        public double? MetricTarget { get; set; }

        /// <summary>
        /// metricType
        /// </summary>
        [NameInMap("metricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// minCapacity
        /// </summary>
        [NameInMap("minCapacity")]
        [Validation(Required=false)]
        public long? MinCapacity { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// startTime
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}

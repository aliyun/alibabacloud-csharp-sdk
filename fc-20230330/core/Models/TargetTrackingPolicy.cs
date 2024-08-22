// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TargetTrackingPolicy : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("maxCapacity")]
        [Validation(Required=false)]
        public long? MaxCapacity { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("metricTarget")]
        [Validation(Required=false)]
        public float? MetricTarget { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("metricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("minCapacity")]
        [Validation(Required=false)]
        public long? MinCapacity { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}

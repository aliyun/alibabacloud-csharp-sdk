// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateTimingSyntheticTaskShrinkRequest : TeaModel {
        /// <summary>
        /// The list of assertions.
        /// </summary>
        [NameInMap("AvailableAssertions")]
        [Validation(Required=false)]
        public string AvailableAssertionsShrink { get; set; }

        /// <summary>
        /// The general settings.
        /// </summary>
        [NameInMap("CommonSetting")]
        [Validation(Required=false)]
        public string CommonSettingShrink { get; set; }

        /// <summary>
        /// The custom cycle.
        /// </summary>
        [NameInMap("CustomPeriod")]
        [Validation(Required=false)]
        public string CustomPeriodShrink { get; set; }

        /// <summary>
        /// The detection frequency. Valid values: 1m, 5m, 10m, 15m, 20m, 30m, 1h, 2h, 3h, 4h, 6h, 8h, 12h, and 24h.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The monitoring configurations.
        /// </summary>
        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public string MonitorConfShrink { get; set; }

        /// <summary>
        /// The list of monitoring points.
        /// </summary>
        [NameInMap("Monitors")]
        [Validation(Required=false)]
        public string MonitorsShrink { get; set; }

        /// <summary>
        /// The name of the task.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// The ID of the synthetic monitoring task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateTimingSyntheticTaskShrinkRequest : TeaModel {
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
        /// The general settings.
        /// </summary>
        [NameInMap("CustomPeriod")]
        [Validation(Required=false)]
        public string CustomPeriodShrink { get; set; }

        /// <summary>
        /// The detection frequency. Valid values: 1m, 5m, 10m, 15m, 20m, 30m, 1h, 2h, 3h, 4h, 6h, 8h, 12h, and 24h.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The detection point type. Valid values:
        /// 
        /// - 1: PC
        /// - 2: mobile device
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorCategory")]
        [Validation(Required=false)]
        public int? MonitorCategory { get; set; }

        /// <summary>
        /// The monitoring configurations.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public string MonitorConfShrink { get; set; }

        /// <summary>
        /// The list of detection points.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Monitors")]
        [Validation(Required=false)]
        public string MonitorsShrink { get; set; }

        /// <summary>
        /// The name of the task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The parameter is optional.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tag list.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// The type of the task. Valid values:
        /// 
        /// 1: ICMP. 2: TCP. 3: DNS. 4: HTTP. 5: website speed measurement. 6: file download.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

    }

}

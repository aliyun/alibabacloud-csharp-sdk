// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateTimingSyntheticTaskShrinkRequest : TeaModel {
        [NameInMap("AvailableAssertions")]
        [Validation(Required=false)]
        public string AvailableAssertionsShrink { get; set; }

        /// <summary>
        /// The general settings.
        /// </summary>
        [NameInMap("CommonSetting")]
        [Validation(Required=false)]
        public string CommonSettingShrink { get; set; }

        [NameInMap("CustomPeriod")]
        [Validation(Required=false)]
        public string CustomPeriodShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
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

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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

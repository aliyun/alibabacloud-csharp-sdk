// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateTimingSyntheticTaskShrinkRequest : TeaModel {
        [NameInMap("AvailableAssertions")]
        [Validation(Required=false)]
        public string AvailableAssertionsShrink { get; set; }

        [NameInMap("CommonSetting")]
        [Validation(Required=false)]
        public string CommonSettingShrink { get; set; }

        [NameInMap("CustomPeriod")]
        [Validation(Required=false)]
        public string CustomPeriodShrink { get; set; }

        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        [NameInMap("MonitorCategory")]
        [Validation(Required=false)]
        public int? MonitorCategory { get; set; }

        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public string MonitorConfShrink { get; set; }

        [NameInMap("Monitors")]
        [Validation(Required=false)]
        public string MonitorsShrink { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

    }

}

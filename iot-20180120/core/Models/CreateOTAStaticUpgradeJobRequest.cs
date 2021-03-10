// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateOTAStaticUpgradeJobRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("FirmwareId")]
        [Validation(Required=true)]
        public string FirmwareId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("TargetSelection")]
        [Validation(Required=true)]
        public string TargetSelection { get; set; }

        [NameInMap("SrcVersion")]
        [Validation(Required=false)]
        public List<string> SrcVersion { get; set; }

        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        [NameInMap("RetryCount")]
        [Validation(Required=false)]
        public int? RetryCount { get; set; }

        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

        [NameInMap("MaximumPerMinute")]
        [Validation(Required=false)]
        public int? MaximumPerMinute { get; set; }

        [NameInMap("GrayPercent")]
        [Validation(Required=false)]
        public string GrayPercent { get; set; }

        [NameInMap("TargetDeviceName")]
        [Validation(Required=false)]
        public List<string> TargetDeviceName { get; set; }

        [NameInMap("ScheduleFinishTime")]
        [Validation(Required=false)]
        public long? ScheduleFinishTime { get; set; }

        [NameInMap("OverwriteMode")]
        [Validation(Required=false)]
        public int? OverwriteMode { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateOTAStaticUpgradeJobRequestTag> Tag { get; set; }
        public class CreateOTAStaticUpgradeJobRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=true)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=true)]
            public string Value { get; set; }

        }

        [NameInMap("DnListFileUrl")]
        [Validation(Required=false)]
        public string DnListFileUrl { get; set; }

    }

}

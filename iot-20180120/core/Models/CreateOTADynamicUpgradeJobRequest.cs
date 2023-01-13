// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateOTADynamicUpgradeJobRequest : TeaModel {
        [NameInMap("DownloadProtocol")]
        [Validation(Required=false)]
        public string DownloadProtocol { get; set; }

        [NameInMap("DynamicMode")]
        [Validation(Required=false)]
        public int? DynamicMode { get; set; }

        [NameInMap("FirmwareId")]
        [Validation(Required=true)]
        public string FirmwareId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("MaximumPerMinute")]
        [Validation(Required=false)]
        public int? MaximumPerMinute { get; set; }

        [NameInMap("MultiModuleMode")]
        [Validation(Required=false)]
        public bool? MultiModuleMode { get; set; }

        [NameInMap("NeedConfirm")]
        [Validation(Required=false)]
        public bool? NeedConfirm { get; set; }

        [NameInMap("NeedPush")]
        [Validation(Required=false)]
        public bool? NeedPush { get; set; }

        [NameInMap("OverwriteMode")]
        [Validation(Required=false)]
        public int? OverwriteMode { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("RetryCount")]
        [Validation(Required=false)]
        public int? RetryCount { get; set; }

        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        [NameInMap("SrcVersion")]
        [Validation(Required=false)]
        public List<string> SrcVersion { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateOTADynamicUpgradeJobRequestTag> Tag { get; set; }
        public class CreateOTADynamicUpgradeJobRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=true)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=true)]
            public string Value { get; set; }

        }

        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

    }

}

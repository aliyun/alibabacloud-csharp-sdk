// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateOTAVerifyJobRequest : TeaModel {
        [NameInMap("DownloadProtocol")]
        [Validation(Required=false)]
        public string DownloadProtocol { get; set; }

        [NameInMap("FirmwareId")]
        [Validation(Required=false)]
        public string FirmwareId { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("NeedConfirm")]
        [Validation(Required=false)]
        public bool? NeedConfirm { get; set; }

        [NameInMap("NeedPush")]
        [Validation(Required=false)]
        public bool? NeedPush { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateOTAVerifyJobRequestTag> Tag { get; set; }
        public class CreateOTAVerifyJobRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TargetDeviceName")]
        [Validation(Required=false)]
        public List<string> TargetDeviceName { get; set; }

        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateOTAVerifyJobRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("FirmwareId")]
        [Validation(Required=false)]
        public string FirmwareId { get; set; }

        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("TargetDeviceName")]
        [Validation(Required=false)]
        public List<string> TargetDeviceName { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class RegisterDeviceRequest : TeaModel {
        [NameInMap("DeviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        [NameInMap("DeviceTimeStamp")]
        [Validation(Required=false)]
        public string DeviceTimeStamp { get; set; }

    }

}

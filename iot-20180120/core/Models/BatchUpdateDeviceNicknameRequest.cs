// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchUpdateDeviceNicknameRequest : TeaModel {
        [NameInMap("DeviceNicknameInfo")]
        [Validation(Required=true)]
        public List<BatchUpdateDeviceNicknameRequestDeviceNicknameInfo> DeviceNicknameInfo { get; set; }
        public class BatchUpdateDeviceNicknameRequestDeviceNicknameInfo : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            [NameInMap("Nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

        }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}

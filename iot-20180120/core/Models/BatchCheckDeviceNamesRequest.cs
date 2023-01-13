// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchCheckDeviceNamesRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public List<string> DeviceName { get; set; }

        [NameInMap("DeviceNameList")]
        [Validation(Required=false)]
        public List<BatchCheckDeviceNamesRequestDeviceNameList> DeviceNameList { get; set; }
        public class BatchCheckDeviceNamesRequestDeviceNameList : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("DeviceNickname")]
            [Validation(Required=false)]
            public string DeviceNickname { get; set; }

        }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

    }

}

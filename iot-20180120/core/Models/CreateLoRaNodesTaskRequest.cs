// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateLoRaNodesTaskRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=true)]
        public List<CreateLoRaNodesTaskRequestDeviceInfo> DeviceInfo { get; set; }
        public class CreateLoRaNodesTaskRequestDeviceInfo : TeaModel {
            [NameInMap("DevEui")]
            [Validation(Required=false)]
            public string DevEui { get; set; }

            [NameInMap("PinCode")]
            [Validation(Required=false)]
            public string PinCode { get; set; }

        }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

    }

}

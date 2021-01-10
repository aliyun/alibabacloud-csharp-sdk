// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateLoRaNodesTaskRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public List<CreateLoRaNodesTaskRequestDeviceInfo> DeviceInfo { get; set; }
        public class CreateLoRaNodesTaskRequestDeviceInfo : TeaModel {
            [NameInMap("DevEui")]
            [Validation(Required=false)]
            public string DevEui { get; set; }

            [NameInMap("PinCode")]
            [Validation(Required=false)]
            public string PinCode { get; set; }

        }

    }

}

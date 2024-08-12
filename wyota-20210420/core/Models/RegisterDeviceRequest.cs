// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class RegisterDeviceRequest : TeaModel {
        [NameInMap("Bluetooth")]
        [Validation(Required=false)]
        public string Bluetooth { get; set; }

        [NameInMap("BuildId")]
        [Validation(Required=false)]
        public string BuildId { get; set; }

        [NameInMap("ChipId")]
        [Validation(Required=false)]
        public string ChipId { get; set; }

        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        [NameInMap("EtherMac")]
        [Validation(Required=false)]
        public string EtherMac { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("Wlan")]
        [Validation(Required=false)]
        public string Wlan { get; set; }

    }

}

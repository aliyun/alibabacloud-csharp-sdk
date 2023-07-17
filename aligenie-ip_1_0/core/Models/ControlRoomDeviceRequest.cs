// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ControlRoomDeviceRequest : TeaModel {
        [NameInMap("Cmd")]
        [Validation(Required=false)]
        public string Cmd { get; set; }

        [NameInMap("DeviceNumber")]
        [Validation(Required=false)]
        public string DeviceNumber { get; set; }

        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("Properties")]
        [Validation(Required=false)]
        public Dictionary<string, string> Properties { get; set; }

        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

    }

}

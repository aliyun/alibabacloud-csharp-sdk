// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class SyncDeviceStatusWithAkRequest : TeaModel {
        [NameInMap("CategoryCnName")]
        [Validation(Required=false)]
        public string CategoryCnName { get; set; }

        [NameInMap("CategoryEnName")]
        [Validation(Required=false)]
        public string CategoryEnName { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("LocationCnName")]
        [Validation(Required=false)]
        public string LocationCnName { get; set; }

        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

        [NameInMap("Switch")]
        [Validation(Required=false)]
        public int? Switch { get; set; }

        [NameInMap("fanSpeed")]
        [Validation(Required=false)]
        public string FanSpeed { get; set; }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("roomTemperature")]
        [Validation(Required=false)]
        public string RoomTemperature { get; set; }

        [NameInMap("temperature")]
        [Validation(Required=false)]
        public string Temperature { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public int? Value { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ImportRoomControlDevicesRequest : TeaModel {
        [NameInMap("EnableInfraredDeviceImport")]
        [Validation(Required=false)]
        public string EnableInfraredDeviceImport { get; set; }

        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("LocationDevices")]
        [Validation(Required=false)]
        public List<ImportRoomControlDevicesRequestLocationDevices> LocationDevices { get; set; }
        public class ImportRoomControlDevicesRequestLocationDevices : TeaModel {
            [NameInMap("Devices")]
            [Validation(Required=false)]
            public List<ImportRoomControlDevicesRequestLocationDevicesDevices> Devices { get; set; }
            public class ImportRoomControlDevicesRequestLocationDevicesDevices : TeaModel {
                [NameInMap("Brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }

                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("ConnectType")]
                [Validation(Required=false)]
                public string ConnectType { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("InfraredId")]
                [Validation(Required=false)]
                public string InfraredId { get; set; }

                [NameInMap("InfraredIndex")]
                [Validation(Required=false)]
                public string InfraredIndex { get; set; }

                [NameInMap("InfraredVersion")]
                [Validation(Required=false)]
                public string InfraredVersion { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                [NameInMap("ServiceProvider")]
                [Validation(Required=false)]
                public string ServiceProvider { get; set; }

            }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("LocationName")]
            [Validation(Required=false)]
            public string LocationName { get; set; }

        }

        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

    }

}

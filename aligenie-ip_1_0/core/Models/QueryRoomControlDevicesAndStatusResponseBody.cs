// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryRoomControlDevicesAndStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryRoomControlDevicesAndStatusResponseBodyResult> Result { get; set; }
        public class QueryRoomControlDevicesAndStatusResponseBodyResult : TeaModel {
            [NameInMap("Devices")]
            [Validation(Required=false)]
            public List<QueryRoomControlDevicesAndStatusResponseBodyResultDevices> Devices { get; set; }
            public class QueryRoomControlDevicesAndStatusResponseBodyResultDevices : TeaModel {
                [NameInMap("AliasList")]
                [Validation(Required=false)]
                public List<string> AliasList { get; set; }

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

                [NameInMap("DeviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                [NameInMap("Dn")]
                [Validation(Required=false)]
                public string Dn { get; set; }

                [NameInMap("InfraredId")]
                [Validation(Required=false)]
                public string InfraredId { get; set; }

                [NameInMap("InfraredIndex")]
                [Validation(Required=false)]
                public string InfraredIndex { get; set; }

                [NameInMap("InfraredVersion")]
                [Validation(Required=false)]
                public string InfraredVersion { get; set; }

                [NameInMap("MultiKeySwitchExt")]
                [Validation(Required=false)]
                public QueryRoomControlDevicesAndStatusResponseBodyResultDevicesMultiKeySwitchExt MultiKeySwitchExt { get; set; }
                public class QueryRoomControlDevicesAndStatusResponseBodyResultDevicesMultiKeySwitchExt : TeaModel {
                    [NameInMap("SwitchList")]
                    [Validation(Required=false)]
                    public List<QueryRoomControlDevicesAndStatusResponseBodyResultDevicesMultiKeySwitchExtSwitchList> SwitchList { get; set; }
                    public class QueryRoomControlDevicesAndStatusResponseBodyResultDevicesMultiKeySwitchExtSwitchList : TeaModel {
                        [NameInMap("AliasList")]
                        [Validation(Required=false)]
                        public List<string> AliasList { get; set; }

                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("DeviceIndex")]
                        [Validation(Required=false)]
                        public int? DeviceIndex { get; set; }

                        [NameInMap("DeviceName")]
                        [Validation(Required=false)]
                        public string DeviceName { get; set; }

                        [NameInMap("DeviceStatus")]
                        [Validation(Required=false)]
                        public string DeviceStatus { get; set; }

                        [NameInMap("ElementCode")]
                        [Validation(Required=false)]
                        public string ElementCode { get; set; }

                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Status { get; set; }

                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public List<string> Tags { get; set; }

                    }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                [NameInMap("Pk")]
                [Validation(Required=false)]
                public string Pk { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                [NameInMap("ServiceProvider")]
                [Validation(Required=false)]
                public string ServiceProvider { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public Dictionary<string, string> Status { get; set; }

            }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("LocationName")]
            [Validation(Required=false)]
            public string LocationName { get; set; }

            [NameInMap("RoomNo")]
            [Validation(Required=false)]
            public string RoomNo { get; set; }

        }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

    }

}

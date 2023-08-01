// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryRoomControlDevicesResponseBody : TeaModel {
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
        public List<QueryRoomControlDevicesResponseBodyResult> Result { get; set; }
        public class QueryRoomControlDevicesResponseBodyResult : TeaModel {
            [NameInMap("Devices")]
            [Validation(Required=false)]
            public List<QueryRoomControlDevicesResponseBodyResultDevices> Devices { get; set; }
            public class QueryRoomControlDevicesResponseBodyResultDevices : TeaModel {
                [NameInMap("ConnectType")]
                [Validation(Required=false)]
                public string ConnectType { get; set; }

                [NameInMap("DN")]
                [Validation(Required=false)]
                public string DN { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("DeviceStatus")]
                [Validation(Required=false)]
                public string DeviceStatus { get; set; }

                [NameInMap("MultiKeySwitchExt")]
                [Validation(Required=false)]
                public QueryRoomControlDevicesResponseBodyResultDevicesMultiKeySwitchExt MultiKeySwitchExt { get; set; }
                public class QueryRoomControlDevicesResponseBodyResultDevicesMultiKeySwitchExt : TeaModel {
                    [NameInMap("SwitchList")]
                    [Validation(Required=false)]
                    public List<QueryRoomControlDevicesResponseBodyResultDevicesMultiKeySwitchExtSwitchList> SwitchList { get; set; }
                    public class QueryRoomControlDevicesResponseBodyResultDevicesMultiKeySwitchExtSwitchList : TeaModel {
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

                    }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                [NameInMap("PK")]
                [Validation(Required=false)]
                public string PK { get; set; }

            }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("LocationName")]
            [Validation(Required=false)]
            public string LocationName { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryVehicleDeviceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryVehicleDeviceResponseData Data { get; set; }
        public class QueryVehicleDeviceResponseData : TeaModel {
            [NameInMap("AuthCode")]
            [Validation(Required=true)]
            public string AuthCode { get; set; }

            [NameInMap("City")]
            [Validation(Required=true)]
            public string City { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public long? CreateTime { get; set; }

            [NameInMap("DeviceId")]
            [Validation(Required=true)]
            public string DeviceId { get; set; }

            [NameInMap("DeviceModel")]
            [Validation(Required=true)]
            public string DeviceModel { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }

            [NameInMap("Manufacturer")]
            [Validation(Required=true)]
            public string Manufacturer { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=true)]
            public long? ModifiedTime { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }

            [NameInMap("Province")]
            [Validation(Required=true)]
            public string Province { get; set; }

            [NameInMap("RegisterTime")]
            [Validation(Required=true)]
            public long? RegisterTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("VehicleColour")]
            [Validation(Required=true)]
            public string VehicleColour { get; set; }

            [NameInMap("VehicleNumber")]
            [Validation(Required=true)]
            public string VehicleNumber { get; set; }

        }

    }

}

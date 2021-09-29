// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetCommercialVehicleDeviceResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VehicleDevice")]
        [Validation(Required=false)]
        public GetCommercialVehicleDeviceResponseBodyVehicleDevice VehicleDevice { get; set; }
        public class GetCommercialVehicleDeviceResponseBodyVehicleDevice : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }
            [NameInMap("HardwareId")]
            [Validation(Required=false)]
            public string HardwareId { get; set; }
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }
            [NameInMap("ManufacturerId")]
            [Validation(Required=false)]
            public string ManufacturerId { get; set; }
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }
            [NameInMap("OnlineStatus")]
            [Validation(Required=false)]
            public long? OnlineStatus { get; set; }
            [NameInMap("PlateColor")]
            [Validation(Required=false)]
            public long? PlateColor { get; set; }
            [NameInMap("PlateNumber")]
            [Validation(Required=false)]
            public string PlateNumber { get; set; }
            [NameInMap("Vin")]
            [Validation(Required=false)]
            public string Vin { get; set; }
            [NameInMap("Imei")]
            [Validation(Required=false)]
            public string Imei { get; set; }
            [NameInMap("SoftVersion")]
            [Validation(Required=false)]
            public string SoftVersion { get; set; }
            [NameInMap("LastAuthTime")]
            [Validation(Required=false)]
            public long? LastAuthTime { get; set; }
        };

    }

}

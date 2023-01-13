// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchImportVehicleDeviceRequest : TeaModel {
        [NameInMap("DeviceList")]
        [Validation(Required=true)]
        public List<BatchImportVehicleDeviceRequestDeviceList> DeviceList { get; set; }
        public class BatchImportVehicleDeviceRequestDeviceList : TeaModel {
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            [NameInMap("DeviceModel")]
            [Validation(Required=true)]
            public string DeviceModel { get; set; }

            [NameInMap("Manufacturer")]
            [Validation(Required=true)]
            public string Manufacturer { get; set; }

        }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

    }

}

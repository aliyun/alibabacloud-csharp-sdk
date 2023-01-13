// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchCheckVehicleDeviceResponse : TeaModel {
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
        public BatchCheckVehicleDeviceResponseData Data { get; set; }
        public class BatchCheckVehicleDeviceResponseData : TeaModel {
            [NameInMap("InvalidDeviceIdList")]
            [Validation(Required=true)]
            public List<string> InvalidDeviceIdList { get; set; }

            [NameInMap("InvalidDeviceModelList")]
            [Validation(Required=true)]
            public List<string> InvalidDeviceModelList { get; set; }

            [NameInMap("InvalidManufacturerList")]
            [Validation(Required=true)]
            public List<string> InvalidManufacturerList { get; set; }

            [NameInMap("RepeatedDeviceIdList")]
            [Validation(Required=true)]
            public List<string> RepeatedDeviceIdList { get; set; }

        }

    }

}

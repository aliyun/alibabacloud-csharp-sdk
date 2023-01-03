// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchCheckVehicleDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchCheckVehicleDeviceResponseBodyData Data { get; set; }
        public class BatchCheckVehicleDeviceResponseBodyData : TeaModel {
            [NameInMap("InvalidDeviceIdList")]
            [Validation(Required=false)]
            public List<string> InvalidDeviceIdList { get; set; }

            [NameInMap("InvalidDeviceModelList")]
            [Validation(Required=false)]
            public List<string> InvalidDeviceModelList { get; set; }

            [NameInMap("InvalidManufacturerList")]
            [Validation(Required=false)]
            public List<string> InvalidManufacturerList { get; set; }

            [NameInMap("RepeatedDeviceIdList")]
            [Validation(Required=false)]
            public List<string> RepeatedDeviceIdList { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

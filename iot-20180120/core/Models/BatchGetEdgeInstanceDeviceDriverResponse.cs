// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeInstanceDeviceDriverResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("DeviceDriverList")]
        [Validation(Required=true)]
        public List<BatchGetEdgeInstanceDeviceDriverResponseDeviceDriverList> DeviceDriverList { get; set; }
        public class BatchGetEdgeInstanceDeviceDriverResponseDeviceDriverList : TeaModel {
            [NameInMap("DriverId")]
            [Validation(Required=true)]
            public string DriverId { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }

        }

    }

}

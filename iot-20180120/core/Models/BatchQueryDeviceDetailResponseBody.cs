// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchQueryDeviceDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public BatchQueryDeviceDetailResponseBodyData Data { get; set; }
        public class BatchQueryDeviceDetailResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<BatchQueryDeviceDetailResponseBodyDataData> Data { get; set; }
            public class BatchQueryDeviceDetailResponseBodyDataData : TeaModel {
                public string DeviceName { get; set; }
                public string DeviceSecret { get; set; }
                public string FirmwareVersion { get; set; }
                public string GmtActive { get; set; }
                public string GmtCreate { get; set; }
                public string IotId { get; set; }
                public string Nickname { get; set; }
                public int? NodeType { get; set; }
                public string ProductKey { get; set; }
                public string ProductName { get; set; }
                public string Region { get; set; }
                public string Status { get; set; }
                public string UtcActive { get; set; }
                public string UtcCreate { get; set; }
            }
        };

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

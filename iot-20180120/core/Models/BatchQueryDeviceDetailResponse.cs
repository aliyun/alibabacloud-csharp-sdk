// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchQueryDeviceDetailResponse : TeaModel {
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

        [NameInMap("Data")]
        [Validation(Required=true)]
        public BatchQueryDeviceDetailResponseData Data { get; set; }
        public class BatchQueryDeviceDetailResponseData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=true)]
            public List<BatchQueryDeviceDetailResponseDataData> Data { get; set; }
            public class BatchQueryDeviceDetailResponseDataData : TeaModel {
                public string ProductKey { get; set; }
                public string ProductName { get; set; }
                public string DeviceName { get; set; }
                public string Nickname { get; set; }
                public string DeviceSecret { get; set; }
                public string IotId { get; set; }
                public string UtcCreate { get; set; }
                public string GmtCreate { get; set; }
                public string UtcActive { get; set; }
                public string GmtActive { get; set; }
                public string Status { get; set; }
                public string FirmwareVersion { get; set; }
                public int? NodeType { get; set; }
                public string Region { get; set; }
            }
        };

    }

}

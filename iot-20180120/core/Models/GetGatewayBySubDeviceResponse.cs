// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetGatewayBySubDeviceResponse : TeaModel {
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
        public GetGatewayBySubDeviceResponseData Data { get; set; }
        public class GetGatewayBySubDeviceResponseData : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }
            [NameInMap("ProductName")]
            [Validation(Required=true)]
            public string ProductName { get; set; }
            [NameInMap("DeviceSecret")]
            [Validation(Required=true)]
            public string DeviceSecret { get; set; }
            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }
            [NameInMap("FirmwareVersion")]
            [Validation(Required=true)]
            public string FirmwareVersion { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public string GmtCreate { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=true)]
            public string UtcCreate { get; set; }
            [NameInMap("GmtActive")]
            [Validation(Required=true)]
            public string GmtActive { get; set; }
            [NameInMap("UtcActive")]
            [Validation(Required=true)]
            public string UtcActive { get; set; }
            [NameInMap("GmtOnline")]
            [Validation(Required=true)]
            public string GmtOnline { get; set; }
            [NameInMap("UtcOnline")]
            [Validation(Required=true)]
            public string UtcOnline { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("IpAddress")]
            [Validation(Required=true)]
            public string IpAddress { get; set; }
            [NameInMap("NodeType")]
            [Validation(Required=true)]
            public string NodeType { get; set; }
            [NameInMap("region")]
            [Validation(Required=true)]
            public string Region { get; set; }
            [NameInMap("iotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }
        };

    }

}

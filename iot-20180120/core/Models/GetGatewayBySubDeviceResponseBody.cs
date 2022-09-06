// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetGatewayBySubDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayBySubDeviceResponseBodyData Data { get; set; }
        public class GetGatewayBySubDeviceResponseBodyData : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("DeviceSecret")]
            [Validation(Required=false)]
            public string DeviceSecret { get; set; }

            [NameInMap("FirmwareVersion")]
            [Validation(Required=false)]
            public string FirmwareVersion { get; set; }

            [NameInMap("GmtActive")]
            [Validation(Required=false)]
            public string GmtActive { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtOnline")]
            [Validation(Required=false)]
            public string GmtOnline { get; set; }

            [NameInMap("IpAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UtcActive")]
            [Validation(Required=false)]
            public string UtcActive { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcOnline")]
            [Validation(Required=false)]
            public string UtcOnline { get; set; }

            [NameInMap("iotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

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

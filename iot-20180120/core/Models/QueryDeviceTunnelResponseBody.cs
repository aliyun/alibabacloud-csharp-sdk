// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceTunnelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceTunnelResponseBodyData Data { get; set; }
        public class QueryDeviceTunnelResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DeviceConnState")]
            [Validation(Required=false)]
            public string DeviceConnState { get; set; }
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }
            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }
            [NameInMap("SourceConnState")]
            [Validation(Required=false)]
            public string SourceConnState { get; set; }
            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }
            [NameInMap("TunnelState")]
            [Validation(Required=false)]
            public string TunnelState { get; set; }
            [NameInMap("Udi")]
            [Validation(Required=false)]
            public string Udi { get; set; }
            [NameInMap("UtcClosed")]
            [Validation(Required=false)]
            public string UtcClosed { get; set; }
            [NameInMap("UtcCreated")]
            [Validation(Required=false)]
            public string UtcCreated { get; set; }
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

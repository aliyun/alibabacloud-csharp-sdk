// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceTunnelResponse : TeaModel {
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
        public QueryDeviceTunnelResponseData Data { get; set; }
        public class QueryDeviceTunnelResponseData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

            [NameInMap("DeviceConnState")]
            [Validation(Required=true)]
            public string DeviceConnState { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=true)]
            public string ProductName { get; set; }

            [NameInMap("SourceConnState")]
            [Validation(Required=true)]
            public string SourceConnState { get; set; }

            [NameInMap("TunnelId")]
            [Validation(Required=true)]
            public string TunnelId { get; set; }

            [NameInMap("TunnelState")]
            [Validation(Required=true)]
            public string TunnelState { get; set; }

            [NameInMap("Udi")]
            [Validation(Required=true)]
            public string Udi { get; set; }

            [NameInMap("UtcClosed")]
            [Validation(Required=true)]
            public string UtcClosed { get; set; }

            [NameInMap("UtcCreated")]
            [Validation(Required=true)]
            public string UtcCreated { get; set; }

        }

    }

}

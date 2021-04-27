// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceStatisticsResponseBodyData Data { get; set; }
        public class QueryDeviceStatisticsResponseBodyData : TeaModel {
            [NameInMap("deviceCount")]
            [Validation(Required=false)]
            public long? DeviceCount { get; set; }
            [NameInMap("onlineCount")]
            [Validation(Required=false)]
            public long? OnlineCount { get; set; }
            [NameInMap("activeCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }
        };

    }

}

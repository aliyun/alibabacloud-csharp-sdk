// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceStatisticsResponse : TeaModel {
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
        public QueryDeviceStatisticsResponseData Data { get; set; }
        public class QueryDeviceStatisticsResponseData : TeaModel {
            [NameInMap("activeCount")]
            [Validation(Required=true)]
            public long? ActiveCount { get; set; }

            [NameInMap("deviceCount")]
            [Validation(Required=true)]
            public long? DeviceCount { get; set; }

            [NameInMap("onlineCount")]
            [Validation(Required=true)]
            public long? OnlineCount { get; set; }

        }

    }

}

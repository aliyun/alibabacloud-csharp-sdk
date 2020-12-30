// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryDeviceStatResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AppDeviceStats")]
        [Validation(Required=false)]
        public QueryDeviceStatResponseBodyAppDeviceStats AppDeviceStats { get; set; }
        public class QueryDeviceStatResponseBodyAppDeviceStats : TeaModel {
            [NameInMap("AppDeviceStat")]
            [Validation(Required=false)]
            public List<QueryDeviceStatResponseBodyAppDeviceStatsAppDeviceStat> AppDeviceStat { get; set; }
            public class QueryDeviceStatResponseBodyAppDeviceStatsAppDeviceStat : TeaModel {
                public string Time { get; set; }
                public string DeviceType { get; set; }
                public long? Count { get; set; }
            }
        };

    }

}

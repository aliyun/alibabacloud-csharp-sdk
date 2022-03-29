// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryDeviceStatResponseBody : TeaModel {
        [NameInMap("AppDeviceStats")]
        [Validation(Required=false)]
        public QueryDeviceStatResponseBodyAppDeviceStats AppDeviceStats { get; set; }
        public class QueryDeviceStatResponseBodyAppDeviceStats : TeaModel {
            [NameInMap("AppDeviceStat")]
            [Validation(Required=false)]
            public List<QueryDeviceStatResponseBodyAppDeviceStatsAppDeviceStat> AppDeviceStat { get; set; }
            public class QueryDeviceStatResponseBodyAppDeviceStatsAppDeviceStat : TeaModel {
                public long? Count { get; set; }
                public string DeviceType { get; set; }
                public string Time { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

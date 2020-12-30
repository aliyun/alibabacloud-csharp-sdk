// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryUniqueDeviceStatResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AppDeviceStats")]
        [Validation(Required=false)]
        public QueryUniqueDeviceStatResponseBodyAppDeviceStats AppDeviceStats { get; set; }
        public class QueryUniqueDeviceStatResponseBodyAppDeviceStats : TeaModel {
            [NameInMap("AppDeviceStat")]
            [Validation(Required=false)]
            public List<QueryUniqueDeviceStatResponseBodyAppDeviceStatsAppDeviceStat> AppDeviceStat { get; set; }
            public class QueryUniqueDeviceStatResponseBodyAppDeviceStatsAppDeviceStat : TeaModel {
                public string Time { get; set; }
                public long? Count { get; set; }
            }
        };

    }

}

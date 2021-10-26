// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeRegionTrafficResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficPerSecond")]
        [Validation(Required=false)]
        public DescribeRegionTrafficResponseBodyTrafficPerSecond TrafficPerSecond { get; set; }
        public class DescribeRegionTrafficResponseBodyTrafficPerSecond : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeRegionTrafficResponseBodyTrafficPerSecondMonitorItem> MonitorItem { get; set; }
            public class DescribeRegionTrafficResponseBodyTrafficPerSecondMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
                public string Item { get; set; }
            }
        };

    }

}

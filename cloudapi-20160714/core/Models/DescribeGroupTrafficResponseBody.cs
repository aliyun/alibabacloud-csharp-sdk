// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupTrafficResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficPerSecond")]
        [Validation(Required=false)]
        public DescribeGroupTrafficResponseBodyTrafficPerSecond TrafficPerSecond { get; set; }
        public class DescribeGroupTrafficResponseBodyTrafficPerSecond : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeGroupTrafficResponseBodyTrafficPerSecondMonitorItem> MonitorItem { get; set; }
            public class DescribeGroupTrafficResponseBodyTrafficPerSecondMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
                public string Item { get; set; }
            }
        };

    }

}

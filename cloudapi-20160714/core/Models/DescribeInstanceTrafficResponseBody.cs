// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceTrafficResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceTraffic")]
        [Validation(Required=false)]
        public DescribeInstanceTrafficResponseBodyInstanceTraffic InstanceTraffic { get; set; }
        public class DescribeInstanceTrafficResponseBodyInstanceTraffic : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceTrafficResponseBodyInstanceTrafficMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceTrafficResponseBodyInstanceTrafficMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
                public string Item { get; set; }
            }
        };

    }

}

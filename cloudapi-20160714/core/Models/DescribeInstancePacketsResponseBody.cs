// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstancePacketsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstancePackets")]
        [Validation(Required=false)]
        public DescribeInstancePacketsResponseBodyInstancePackets InstancePackets { get; set; }
        public class DescribeInstancePacketsResponseBodyInstancePackets : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstancePacketsResponseBodyInstancePacketsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstancePacketsResponseBodyInstancePacketsMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
                public string Item { get; set; }
            }
        };

    }

}

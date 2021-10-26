// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceSlbConnectResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceSlbConnect")]
        [Validation(Required=false)]
        public DescribeInstanceSlbConnectResponseBodyInstanceSlbConnect InstanceSlbConnect { get; set; }
        public class DescribeInstanceSlbConnectResponseBodyInstanceSlbConnect : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceSlbConnectResponseBodyInstanceSlbConnectMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceSlbConnectResponseBodyInstanceSlbConnectMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
                public string Item { get; set; }
            }
        };

    }

}

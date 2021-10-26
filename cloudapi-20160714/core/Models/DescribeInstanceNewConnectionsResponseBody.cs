// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceNewConnectionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceNewConnections")]
        [Validation(Required=false)]
        public DescribeInstanceNewConnectionsResponseBodyInstanceNewConnections InstanceNewConnections { get; set; }
        public class DescribeInstanceNewConnectionsResponseBodyInstanceNewConnections : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceNewConnectionsResponseBodyInstanceNewConnectionsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceNewConnectionsResponseBodyInstanceNewConnectionsMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}

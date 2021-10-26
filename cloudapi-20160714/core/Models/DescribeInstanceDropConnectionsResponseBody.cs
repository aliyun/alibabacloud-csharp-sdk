// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceDropConnectionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceDropConnections")]
        [Validation(Required=false)]
        public DescribeInstanceDropConnectionsResponseBodyInstanceDropConnections InstanceDropConnections { get; set; }
        public class DescribeInstanceDropConnectionsResponseBodyInstanceDropConnections : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceDropConnectionsResponseBodyInstanceDropConnectionsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceDropConnectionsResponseBodyInstanceDropConnectionsMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}

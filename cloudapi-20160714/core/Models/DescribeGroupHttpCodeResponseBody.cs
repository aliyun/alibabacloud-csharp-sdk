// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupHttpCodeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpCodePacket")]
        [Validation(Required=false)]
        public DescribeGroupHttpCodeResponseBodyHttpCodePacket HttpCodePacket { get; set; }
        public class DescribeGroupHttpCodeResponseBodyHttpCodePacket : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeGroupHttpCodeResponseBodyHttpCodePacketMonitorItem> MonitorItem { get; set; }
            public class DescribeGroupHttpCodeResponseBodyHttpCodePacketMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}

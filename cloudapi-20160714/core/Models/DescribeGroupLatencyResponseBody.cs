// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupLatencyResponseBody : TeaModel {
        [NameInMap("LatencyPacket")]
        [Validation(Required=false)]
        public DescribeGroupLatencyResponseBodyLatencyPacket LatencyPacket { get; set; }
        public class DescribeGroupLatencyResponseBodyLatencyPacket : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeGroupLatencyResponseBodyLatencyPacketMonitorItem> MonitorItem { get; set; }
            public class DescribeGroupLatencyResponseBodyLatencyPacketMonitorItem : TeaModel {
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

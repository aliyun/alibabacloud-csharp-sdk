// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeRegionHttpCodeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpCodePacket")]
        [Validation(Required=false)]
        public DescribeRegionHttpCodeResponseBodyHttpCodePacket HttpCodePacket { get; set; }
        public class DescribeRegionHttpCodeResponseBodyHttpCodePacket : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeRegionHttpCodeResponseBodyHttpCodePacketMonitorItem> MonitorItem { get; set; }
            public class DescribeRegionHttpCodeResponseBodyHttpCodePacketMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}

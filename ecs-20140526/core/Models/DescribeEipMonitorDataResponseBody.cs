// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeEipMonitorDataResponseBody : TeaModel {
        [NameInMap("EipMonitorDatas")]
        [Validation(Required=false)]
        public DescribeEipMonitorDataResponseBodyEipMonitorDatas EipMonitorDatas { get; set; }
        public class DescribeEipMonitorDataResponseBodyEipMonitorDatas : TeaModel {
            [NameInMap("EipMonitorData")]
            [Validation(Required=false)]
            public List<DescribeEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData> EipMonitorData { get; set; }
            public class DescribeEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData : TeaModel {
                public int? EipBandwidth { get; set; }
                public int? EipFlow { get; set; }
                public int? EipPackets { get; set; }
                public int? EipRX { get; set; }
                public int? EipTX { get; set; }
                public string TimeStamp { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

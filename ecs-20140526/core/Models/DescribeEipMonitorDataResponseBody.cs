// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeEipMonitorDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EipMonitorDatas")]
        [Validation(Required=false)]
        public List<DescribeEipMonitorDataResponseBodyEipMonitorDatas> EipMonitorDatas { get; set; }
        public class DescribeEipMonitorDataResponseBodyEipMonitorDatas : TeaModel {
            [NameInMap("EipTX")]
            [Validation(Required=false)]
            public int? EipTX { get; set; }

            [NameInMap("EipPackets")]
            [Validation(Required=false)]
            public int? EipPackets { get; set; }

            [NameInMap("EipBandwidth")]
            [Validation(Required=false)]
            public int? EipBandwidth { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            [NameInMap("EipFlow")]
            [Validation(Required=false)]
            public int? EipFlow { get; set; }

            [NameInMap("EipRX")]
            [Validation(Required=false)]
            public int? EipRX { get; set; }

        }

    }

}

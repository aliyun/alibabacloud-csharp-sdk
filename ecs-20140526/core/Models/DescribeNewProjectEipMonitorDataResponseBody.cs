// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNewProjectEipMonitorDataResponseBody : TeaModel {
        [NameInMap("EipMonitorDatas")]
        [Validation(Required=false)]
        public DescribeNewProjectEipMonitorDataResponseBodyEipMonitorDatas EipMonitorDatas { get; set; }
        public class DescribeNewProjectEipMonitorDataResponseBodyEipMonitorDatas : TeaModel {
            [NameInMap("EipMonitorData")]
            [Validation(Required=false)]
            public List<DescribeNewProjectEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData> EipMonitorData { get; set; }
            public class DescribeNewProjectEipMonitorDataResponseBodyEipMonitorDatasEipMonitorData : TeaModel {
                [NameInMap("EipBandwidth")]
                [Validation(Required=false)]
                public int? EipBandwidth { get; set; }

                [NameInMap("EipFlow")]
                [Validation(Required=false)]
                public int? EipFlow { get; set; }

                [NameInMap("EipPackets")]
                [Validation(Required=false)]
                public int? EipPackets { get; set; }

                [NameInMap("EipRX")]
                [Validation(Required=false)]
                public int? EipRX { get; set; }

                [NameInMap("EipTX")]
                [Validation(Required=false)]
                public int? EipTX { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnBandWidthDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("MonitorData")]
        [Validation(Required=true)]
        public DescribeEpnBandWidthDataResponseMonitorData MonitorData { get; set; }
        public class DescribeEpnBandWidthDataResponseMonitorData : TeaModel {
            [NameInMap("MaxDownBandWidth")]
            [Validation(Required=true)]
            public long MaxDownBandWidth { get; set; }
            [NameInMap("MaxUpBandWidth")]
            [Validation(Required=true)]
            public long MaxUpBandWidth { get; set; }
            [NameInMap("BandWidthMonitorData")]
            [Validation(Required=true)]
            public List<DescribeEpnBandWidthDataResponseMonitorDataBandWidthMonitorData> BandWidthMonitorData { get; set; }
            public class DescribeEpnBandWidthDataResponseMonitorDataBandWidthMonitorData : TeaModel {
                public long UpBandWidth { get; set; }
                public long DownBandWidth { get; set; }
                public long InternetTX { get; set; }
                public long InternetRX { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}

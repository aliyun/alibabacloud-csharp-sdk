// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEpnBandWidthDataResponseBody : TeaModel {
        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeEpnBandWidthDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeEpnBandWidthDataResponseBodyMonitorData : TeaModel {
            [NameInMap("BandWidthMonitorData")]
            [Validation(Required=false)]
            public List<DescribeEpnBandWidthDataResponseBodyMonitorDataBandWidthMonitorData> BandWidthMonitorData { get; set; }
            public class DescribeEpnBandWidthDataResponseBodyMonitorDataBandWidthMonitorData : TeaModel {
                public long? DownBandWidth { get; set; }
                public long? InternetRX { get; set; }
                public long? InternetTX { get; set; }
                public string TimeStamp { get; set; }
                public long? UpBandWidth { get; set; }
            }
            [NameInMap("MaxDownBandWidth")]
            [Validation(Required=false)]
            public long? MaxDownBandWidth { get; set; }
            [NameInMap("MaxUpBandWidth")]
            [Validation(Required=false)]
            public long? MaxUpBandWidth { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

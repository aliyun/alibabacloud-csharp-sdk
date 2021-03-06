// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeUserBandWidthDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("MonitorData")]
        [Validation(Required=false)]
        public DescribeUserBandWidthDataResponseBodyMonitorData MonitorData { get; set; }
        public class DescribeUserBandWidthDataResponseBodyMonitorData : TeaModel {
            [NameInMap("BandWidthMonitorData")]
            [Validation(Required=false)]
            public List<DescribeUserBandWidthDataResponseBodyMonitorDataBandWidthMonitorData> BandWidthMonitorData { get; set; }
            public class DescribeUserBandWidthDataResponseBodyMonitorDataBandWidthMonitorData : TeaModel {
                public int? DownBandWidth { get; set; }
                public int? InternetRX { get; set; }
                public int? InternetTX { get; set; }
                public string TimeStamp { get; set; }
                public int? UpBandWidth { get; set; }
            }
            [NameInMap("MaxDownBandWidth")]
            [Validation(Required=false)]
            public string MaxDownBandWidth { get; set; }
            [NameInMap("MaxUpBandWidth")]
            [Validation(Required=false)]
            public string MaxUpBandWidth { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

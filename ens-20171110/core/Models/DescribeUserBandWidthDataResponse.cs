// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeUserBandWidthDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("MonitorData")]
        [Validation(Required=true)]
        public DescribeUserBandWidthDataResponseMonitorData MonitorData { get; set; }
        public class DescribeUserBandWidthDataResponseMonitorData : TeaModel {
            [NameInMap("MaxDownBandWidth")]
            [Validation(Required=true)]
            public string MaxDownBandWidth { get; set; }
            [NameInMap("MaxUpBandWidth")]
            [Validation(Required=true)]
            public string MaxUpBandWidth { get; set; }
            [NameInMap("BandWidthMonitorData")]
            [Validation(Required=true)]
            public List<DescribeUserBandWidthDataResponseMonitorDataBandWidthMonitorData> BandWidthMonitorData { get; set; }
            public class DescribeUserBandWidthDataResponseMonitorDataBandWidthMonitorData : TeaModel {
                public int? UpBandWidth { get; set; }
                public int? DownBandWidth { get; set; }
                public int? InternetTX { get; set; }
                public int? InternetRX { get; set; }
                public string TimeStamp { get; set; }
            }
        };

    }

}

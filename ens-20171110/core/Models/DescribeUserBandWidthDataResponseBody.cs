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
                [NameInMap("DownBandWidth")]
                [Validation(Required=false)]
                public long? DownBandWidth { get; set; }

                [NameInMap("InternetRX")]
                [Validation(Required=false)]
                public long? InternetRX { get; set; }

                [NameInMap("InternetTX")]
                [Validation(Required=false)]
                public long? InternetTX { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("UpBandWidth")]
                [Validation(Required=false)]
                public long? UpBandWidth { get; set; }

            }

            [NameInMap("MaxDownBandWidth")]
            [Validation(Required=false)]
            public string MaxDownBandWidth { get; set; }

            [NameInMap("MaxUpBandWidth")]
            [Validation(Required=false)]
            public string MaxUpBandWidth { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUpBpsPeakDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DescribeUpPeakTraffics")]
        [Validation(Required=true)]
        public DescribeUpBpsPeakDataResponseDescribeUpPeakTraffics DescribeUpPeakTraffics { get; set; }
        public class DescribeUpBpsPeakDataResponseDescribeUpPeakTraffics : TeaModel {
            [NameInMap("DescribeUpPeakTraffic")]
            [Validation(Required=true)]
            public List<DescribeUpBpsPeakDataResponseDescribeUpPeakTrafficsDescribeUpPeakTraffic> DescribeUpPeakTraffic { get; set; }
            public class DescribeUpBpsPeakDataResponseDescribeUpPeakTrafficsDescribeUpPeakTraffic : TeaModel {
                public string PeakTime { get; set; }
                public string QueryTime { get; set; }
                public string StatName { get; set; }
                public string BandWidth { get; set; }
            }
        };

    }

}

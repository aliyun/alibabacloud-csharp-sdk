// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUpBpsPeakDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DescribeUpPeakTraffics")]
        [Validation(Required=false)]
        public DescribeUpBpsPeakDataResponseBodyDescribeUpPeakTraffics DescribeUpPeakTraffics { get; set; }
        public class DescribeUpBpsPeakDataResponseBodyDescribeUpPeakTraffics : TeaModel {
            [NameInMap("DescribeUpPeakTraffic")]
            [Validation(Required=false)]
            public List<DescribeUpBpsPeakDataResponseBodyDescribeUpPeakTrafficsDescribeUpPeakTraffic> DescribeUpPeakTraffic { get; set; }
            public class DescribeUpBpsPeakDataResponseBodyDescribeUpPeakTrafficsDescribeUpPeakTraffic : TeaModel {
                public string QueryTime { get; set; }
                public string StatName { get; set; }
                public string PeakTime { get; set; }
                public string BandWidth { get; set; }
            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsUpPeakPublishStreamDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DescribeVsUpPeakPublishStreamDatas")]
        [Validation(Required=false)]
        public DescribeVsUpPeakPublishStreamDataResponseBodyDescribeVsUpPeakPublishStreamDatas DescribeVsUpPeakPublishStreamDatas { get; set; }
        public class DescribeVsUpPeakPublishStreamDataResponseBodyDescribeVsUpPeakPublishStreamDatas : TeaModel {
            [NameInMap("DescribeVsUpPeakPublishStreamData")]
            [Validation(Required=false)]
            public List<DescribeVsUpPeakPublishStreamDataResponseBodyDescribeVsUpPeakPublishStreamDatasDescribeVsUpPeakPublishStreamData> DescribeVsUpPeakPublishStreamData { get; set; }
            public class DescribeVsUpPeakPublishStreamDataResponseBodyDescribeVsUpPeakPublishStreamDatasDescribeVsUpPeakPublishStreamData : TeaModel {
                public string QueryTime { get; set; }
                public string BandWidth { get; set; }
                public string StatName { get; set; }
                public string PeakTime { get; set; }
                public int? PublishStreamNum { get; set; }
            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUpPeakPublishStreamDataResponseBody : TeaModel {
        [NameInMap("DescribeUpPeakPublishStreamDatas")]
        [Validation(Required=false)]
        public DescribeUpPeakPublishStreamDataResponseBodyDescribeUpPeakPublishStreamDatas DescribeUpPeakPublishStreamDatas { get; set; }
        public class DescribeUpPeakPublishStreamDataResponseBodyDescribeUpPeakPublishStreamDatas : TeaModel {
            [NameInMap("DescribeUpPeakPublishStreamData")]
            [Validation(Required=false)]
            public List<DescribeUpPeakPublishStreamDataResponseBodyDescribeUpPeakPublishStreamDatasDescribeUpPeakPublishStreamData> DescribeUpPeakPublishStreamData { get; set; }
            public class DescribeUpPeakPublishStreamDataResponseBodyDescribeUpPeakPublishStreamDatasDescribeUpPeakPublishStreamData : TeaModel {
                public string QueryTime { get; set; }
                public string StatName { get; set; }
                public string PeakTime { get; set; }
                public string BandWidth { get; set; }
                public int? PublishStreamNum { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

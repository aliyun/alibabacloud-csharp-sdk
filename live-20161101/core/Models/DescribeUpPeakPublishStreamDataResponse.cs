// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUpPeakPublishStreamDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DescribeUpPeakPublishStreamDatas")]
        [Validation(Required=true)]
        public DescribeUpPeakPublishStreamDataResponseDescribeUpPeakPublishStreamDatas DescribeUpPeakPublishStreamDatas { get; set; }
        public class DescribeUpPeakPublishStreamDataResponseDescribeUpPeakPublishStreamDatas : TeaModel {
            [NameInMap("DescribeUpPeakPublishStreamData")]
            [Validation(Required=true)]
            public List<DescribeUpPeakPublishStreamDataResponseDescribeUpPeakPublishStreamDatasDescribeUpPeakPublishStreamData> DescribeUpPeakPublishStreamData { get; set; }
            public class DescribeUpPeakPublishStreamDataResponseDescribeUpPeakPublishStreamDatasDescribeUpPeakPublishStreamData : TeaModel {
                public int? PublishStreamNum { get; set; }
                public string PeakTime { get; set; }
                public string QueryTime { get; set; }
                public string StatName { get; set; }
                public string BandWidth { get; set; }
            }
        };

    }

}

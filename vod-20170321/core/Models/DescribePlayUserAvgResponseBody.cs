// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayUserAvgResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserPlayStatisAvgs")]
        [Validation(Required=false)]
        public DescribePlayUserAvgResponseBodyUserPlayStatisAvgs UserPlayStatisAvgs { get; set; }
        public class DescribePlayUserAvgResponseBodyUserPlayStatisAvgs : TeaModel {
            [NameInMap("UserPlayStatisAvg")]
            [Validation(Required=false)]
            public List<DescribePlayUserAvgResponseBodyUserPlayStatisAvgsUserPlayStatisAvg> UserPlayStatisAvg { get; set; }
            public class DescribePlayUserAvgResponseBodyUserPlayStatisAvgsUserPlayStatisAvg : TeaModel {
                [NameInMap("AvgPlayCount")]
                [Validation(Required=false)]
                public string AvgPlayCount { get; set; }

                [NameInMap("AvgPlayDuration")]
                [Validation(Required=false)]
                public string AvgPlayDuration { get; set; }

                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

            }

        }

    }

}

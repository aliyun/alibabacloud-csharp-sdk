// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayMetricDataResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribePlayMetricDataResponseBodyNodes> Nodes { get; set; }
        public class DescribePlayMetricDataResponseBodyNodes : TeaModel {
            [NameInMap("X")]
            [Validation(Required=false)]
            public string X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public string Y { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SummaryData")]
        [Validation(Required=false)]
        public string SummaryData { get; set; }

    }

}

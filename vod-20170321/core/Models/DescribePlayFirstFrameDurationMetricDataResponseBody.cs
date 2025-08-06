// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayFirstFrameDurationMetricDataResponseBody : TeaModel {
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<DescribePlayFirstFrameDurationMetricDataResponseBodyNodes> Nodes { get; set; }
        public class DescribePlayFirstFrameDurationMetricDataResponseBodyNodes : TeaModel {
            [NameInMap("X")]
            [Validation(Required=false)]
            public long? X { get; set; }

            [NameInMap("Y")]
            [Validation(Required=false)]
            public long? Y { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUpBpsPeakOfLineResponseBody : TeaModel {
        [NameInMap("DescribeUpBpsPeakOfLines")]
        [Validation(Required=false)]
        public DescribeUpBpsPeakOfLineResponseBodyDescribeUpBpsPeakOfLines DescribeUpBpsPeakOfLines { get; set; }
        public class DescribeUpBpsPeakOfLineResponseBodyDescribeUpBpsPeakOfLines : TeaModel {
            [NameInMap("DescribeUpBpsPeakOfLine")]
            [Validation(Required=false)]
            public List<DescribeUpBpsPeakOfLineResponseBodyDescribeUpBpsPeakOfLinesDescribeUpBpsPeakOfLine> DescribeUpBpsPeakOfLine { get; set; }
            public class DescribeUpBpsPeakOfLineResponseBodyDescribeUpBpsPeakOfLinesDescribeUpBpsPeakOfLine : TeaModel {
                public string QueryTime { get; set; }
                public string StatName { get; set; }
                public string PeakTime { get; set; }
                public float? BandWidth { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

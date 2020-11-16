// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUpBpsPeakOfLineResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DescribeUpBpsPeakOfLines")]
        [Validation(Required=true)]
        public DescribeUpBpsPeakOfLineResponseDescribeUpBpsPeakOfLines DescribeUpBpsPeakOfLines { get; set; }
        public class DescribeUpBpsPeakOfLineResponseDescribeUpBpsPeakOfLines : TeaModel {
            [NameInMap("DescribeUpBpsPeakOfLine")]
            [Validation(Required=true)]
            public List<DescribeUpBpsPeakOfLineResponseDescribeUpBpsPeakOfLinesDescribeUpBpsPeakOfLine> DescribeUpBpsPeakOfLine { get; set; }
            public class DescribeUpBpsPeakOfLineResponseDescribeUpBpsPeakOfLinesDescribeUpBpsPeakOfLine : TeaModel {
                public float? BandWidth { get; set; }
                public string PeakTime { get; set; }
                public string QueryTime { get; set; }
                public string StatName { get; set; }
            }
        };

    }

}

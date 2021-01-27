// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeCustomEventHistogramResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("EventHistograms")]
        [Validation(Required=false)]
        public DescribeCustomEventHistogramResponseBodyEventHistograms EventHistograms { get; set; }
        public class DescribeCustomEventHistogramResponseBodyEventHistograms : TeaModel {
            [NameInMap("EventHistogram")]
            [Validation(Required=false)]
            public List<DescribeCustomEventHistogramResponseBodyEventHistogramsEventHistogram> EventHistogram { get; set; }
            public class DescribeCustomEventHistogramResponseBodyEventHistogramsEventHistogram : TeaModel {
                public long? EndTime { get; set; }
                public long? StartTime { get; set; }
                public long? Count { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

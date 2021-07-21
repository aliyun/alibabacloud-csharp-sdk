// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventHistogramResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("SystemEventHistograms")]
        [Validation(Required=false)]
        public DescribeSystemEventHistogramResponseBodySystemEventHistograms SystemEventHistograms { get; set; }
        public class DescribeSystemEventHistogramResponseBodySystemEventHistograms : TeaModel {
            [NameInMap("SystemEventHistogram")]
            [Validation(Required=false)]
            public List<DescribeSystemEventHistogramResponseBodySystemEventHistogramsSystemEventHistogram> SystemEventHistogram { get; set; }
            public class DescribeSystemEventHistogramResponseBodySystemEventHistogramsSystemEventHistogram : TeaModel {
                public long? EndTime { get; set; }
                public long? StartTime { get; set; }
                public long? Count { get; set; }
            }
        };

    }

}

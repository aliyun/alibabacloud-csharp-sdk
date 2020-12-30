// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class DescribeUserMetricsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeUserMetricsResponseBodyResult> Result { get; set; }
        public class DescribeUserMetricsResponseBodyResult : TeaModel {
            [NameInMap("DataPoints")]
            [Validation(Required=false)]
            public List<DescribeUserMetricsResponseBodyResultDataPoints> DataPoints { get; set; }
            public class DescribeUserMetricsResponseBodyResultDataPoints : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Val")]
                [Validation(Required=false)]
                public float? Val { get; set; }

            }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

    }

}

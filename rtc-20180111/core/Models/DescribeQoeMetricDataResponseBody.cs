// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQoeMetricDataResponseBody : TeaModel {
        [NameInMap("AudioData")]
        [Validation(Required=false)]
        public List<DescribeQoeMetricDataResponseBodyAudioData> AudioData { get; set; }
        public class DescribeQoeMetricDataResponseBodyAudioData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQoeMetricDataResponseBodyAudioDataNodes> Nodes { get; set; }
            public class DescribeQoeMetricDataResponseBodyAudioDataNodes : TeaModel {
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VideoData")]
        [Validation(Required=false)]
        public List<DescribeQoeMetricDataResponseBodyVideoData> VideoData { get; set; }
        public class DescribeQoeMetricDataResponseBodyVideoData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeQoeMetricDataResponseBodyVideoDataNodes> Nodes { get; set; }
            public class DescribeQoeMetricDataResponseBodyVideoDataNodes : TeaModel {
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}

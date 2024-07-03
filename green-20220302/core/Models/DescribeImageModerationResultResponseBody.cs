// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageModerationResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageModerationResultResponseBodyData Data { get; set; }
        public class DescribeImageModerationResultResponseBodyData : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("Frame")]
            [Validation(Required=false)]
            public string Frame { get; set; }

            [NameInMap("FrameNum")]
            [Validation(Required=false)]
            public int? FrameNum { get; set; }

            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeImageModerationResultResponseBodyDataResult> Result { get; set; }
            public class DescribeImageModerationResultResponseBodyDataResult : TeaModel {
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeUrlModerationResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUrlModerationResultResponseBodyData Data { get; set; }
        public class DescribeUrlModerationResultResponseBodyData : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeUrlModerationResultResponseBodyDataExtraInfo ExtraInfo { get; set; }
            public class DescribeUrlModerationResultResponseBodyDataExtraInfo : TeaModel {
                [NameInMap("IcpNo")]
                [Validation(Required=false)]
                public string IcpNo { get; set; }

                [NameInMap("IcpType")]
                [Validation(Required=false)]
                public string IcpType { get; set; }

            }

            [NameInMap("ReqId")]
            [Validation(Required=false)]
            public string ReqId { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<DescribeUrlModerationResultResponseBodyDataResult> Result { get; set; }
            public class DescribeUrlModerationResultResponseBodyDataResult : TeaModel {
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

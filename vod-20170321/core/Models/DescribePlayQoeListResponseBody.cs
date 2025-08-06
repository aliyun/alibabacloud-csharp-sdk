// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribePlayQoeListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("QoeInfoList")]
        [Validation(Required=false)]
        public List<DescribePlayQoeListResponseBodyQoeInfoList> QoeInfoList { get; set; }
        public class DescribePlayQoeListResponseBodyQoeInfoList : TeaModel {
            [NameInMap("QoeFinishedVV")]
            [Validation(Required=false)]
            public float? QoeFinishedVV { get; set; }

            [NameInMap("QoeFinishedVVRate")]
            [Validation(Required=false)]
            public float? QoeFinishedVVRate { get; set; }

            [NameInMap("QoeJumpRate5s")]
            [Validation(Required=false)]
            public float? QoeJumpRate5s { get; set; }

            [NameInMap("QoeUFinishedVVTime")]
            [Validation(Required=false)]
            public float? QoeUFinishedVVTime { get; set; }

            [NameInMap("QoeUV")]
            [Validation(Required=false)]
            public float? QoeUV { get; set; }

            [NameInMap("QoeUVVDuration")]
            [Validation(Required=false)]
            public float? QoeUVVDuration { get; set; }

            [NameInMap("QoeUVVTime")]
            [Validation(Required=false)]
            public float? QoeUVVTime { get; set; }

            [NameInMap("QoeVDuration")]
            [Validation(Required=false)]
            public float? QoeVDuration { get; set; }

            [NameInMap("QoeVVDuration")]
            [Validation(Required=false)]
            public float? QoeVVDuration { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class RecommendResponseBody : TeaModel {
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
        public List<RecommendResponseBodyResult> Result { get; set; }
        public class RecommendResponseBodyResult : TeaModel {
            [NameInMap("TraceInfo")]
            [Validation(Required=false)]
            public string TraceInfo { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public float? Weight { get; set; }

            [NameInMap("MatchInfo")]
            [Validation(Required=false)]
            public string MatchInfo { get; set; }

            [NameInMap("ItemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            [NameInMap("Position")]
            [Validation(Required=false)]
            public int? Position { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

    }

}

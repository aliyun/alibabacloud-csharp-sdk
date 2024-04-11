// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class QueryMotionShopVideoDetectResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryMotionShopVideoDetectResultResponseBodyData Data { get; set; }
        public class QueryMotionShopVideoDetectResultResponseBodyData : TeaModel {
            [NameInMap("DetectResult")]
            [Validation(Required=false)]
            public QueryMotionShopVideoDetectResultResponseBodyDataDetectResult DetectResult { get; set; }
            public class QueryMotionShopVideoDetectResultResponseBodyDataDetectResult : TeaModel {
                [NameInMap("Box")]
                [Validation(Required=false)]
                public List<double?> Box { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                [NameInMap("HumanBoxes")]
                [Validation(Required=false)]
                public List<List<double?>> HumanBoxes { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("SelectedFrameIndex")]
                [Validation(Required=false)]
                public int? SelectedFrameIndex { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

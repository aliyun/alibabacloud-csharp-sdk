// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class SplitVideoPartsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SplitVideoPartsResponseBodyData Data { get; set; }
        public class SplitVideoPartsResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<SplitVideoPartsResponseBodyDataElements> Elements { get; set; }
            public class SplitVideoPartsResponseBodyDataElements : TeaModel {
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public float? BeginTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

            }

            [NameInMap("SplitVideoPartResults")]
            [Validation(Required=false)]
            public List<SplitVideoPartsResponseBodyDataSplitVideoPartResults> SplitVideoPartResults { get; set; }
            public class SplitVideoPartsResponseBodyDataSplitVideoPartResults : TeaModel {
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public float? BeginTime { get; set; }

                [NameInMap("By")]
                [Validation(Required=false)]
                public string By { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("Theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

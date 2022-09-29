// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videorecog20200320.Models
{
    public class UnderstandVideoContentResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UnderstandVideoContentResponseBodyData Data { get; set; }
        public class UnderstandVideoContentResponseBodyData : TeaModel {
            [NameInMap("TagInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> TagInfo { get; set; }

            [NameInMap("VideoInfo")]
            [Validation(Required=false)]
            public UnderstandVideoContentResponseBodyDataVideoInfo VideoInfo { get; set; }
            public class UnderstandVideoContentResponseBodyDataVideoInfo : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public float? Fps { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

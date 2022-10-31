// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeToutiaoLivePublishResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeToutiaoLivePublishResponseBodyContent> Content { get; set; }
        public class DescribeToutiaoLivePublishResponseBodyContent : TeaModel {
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public float? Bitrate { get; set; }

            [NameInMap("BwDiff")]
            [Validation(Required=false)]
            public float? BwDiff { get; set; }

            [NameInMap("CdnName")]
            [Validation(Required=false)]
            public string CdnName { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Flr")]
            [Validation(Required=false)]
            public float? Flr { get; set; }

            [NameInMap("Fps")]
            [Validation(Required=false)]
            public float? Fps { get; set; }

            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

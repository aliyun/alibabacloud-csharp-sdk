// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class HighlightGameVideoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public HighlightGameVideoResponseBodyData Data { get; set; }
        public class HighlightGameVideoResponseBodyData : TeaModel {
            [NameInMap("HighlightList")]
            [Validation(Required=false)]
            public List<HighlightGameVideoResponseBodyDataHighlightList> HighlightList { get; set; }
            public class HighlightGameVideoResponseBodyDataHighlightList : TeaModel {
                public float? Start { get; set; }
                public float? End { get; set; }
            }
            [NameInMap("GameList")]
            [Validation(Required=false)]
            public List<HighlightGameVideoResponseBodyDataGameList> GameList { get; set; }
            public class HighlightGameVideoResponseBodyDataGameList : TeaModel {
                public Dictionary<string, string> GameInfo { get; set; }
                public float? Start { get; set; }
                public float? End { get; set; }
                public string Id { get; set; }
            }
        };

    }

}

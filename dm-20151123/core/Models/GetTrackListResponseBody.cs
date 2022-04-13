// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetTrackListResponseBody : TeaModel {
        [NameInMap("OffsetCreateTime")]
        [Validation(Required=false)]
        public string OffsetCreateTime { get; set; }

        [NameInMap("OffsetCreateTimeDesc")]
        [Validation(Required=false)]
        public string OffsetCreateTimeDesc { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTrackListResponseBodyData Data { get; set; }
        public class GetTrackListResponseBodyData : TeaModel {
            [NameInMap("stat")]
            [Validation(Required=false)]
            public List<GetTrackListResponseBodyDataStat> Stat { get; set; }
            public class GetTrackListResponseBodyDataStat : TeaModel {
                public string CreateTime { get; set; }
                public string RcptClickCount { get; set; }
                public string RcptClickRate { get; set; }
                public string RcptOpenCount { get; set; }
                public string RcptOpenRate { get; set; }
                public string RcptUniqueClickCount { get; set; }
                public string RcptUniqueClickRate { get; set; }
                public string RcptUniqueOpenCount { get; set; }
                public string RcptUniqueOpenRate { get; set; }
                public string TotalNumber { get; set; }
            }
        };

    }

}

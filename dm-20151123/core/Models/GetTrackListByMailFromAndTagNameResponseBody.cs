// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetTrackListByMailFromAndTagNameResponseBody : TeaModel {
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

        [NameInMap("TrackList")]
        [Validation(Required=false)]
        public GetTrackListByMailFromAndTagNameResponseBodyTrackList TrackList { get; set; }
        public class GetTrackListByMailFromAndTagNameResponseBodyTrackList : TeaModel {
            [NameInMap("Stat")]
            [Validation(Required=false)]
            public List<GetTrackListByMailFromAndTagNameResponseBodyTrackListStat> Stat { get; set; }
            public class GetTrackListByMailFromAndTagNameResponseBodyTrackListStat : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("RcptClickCount")]
                [Validation(Required=false)]
                public string RcptClickCount { get; set; }

                [NameInMap("RcptClickRate")]
                [Validation(Required=false)]
                public string RcptClickRate { get; set; }

                [NameInMap("RcptOpenCount")]
                [Validation(Required=false)]
                public string RcptOpenCount { get; set; }

                [NameInMap("RcptOpenRate")]
                [Validation(Required=false)]
                public string RcptOpenRate { get; set; }

                [NameInMap("RcptUniqueClickCount")]
                [Validation(Required=false)]
                public string RcptUniqueClickCount { get; set; }

                [NameInMap("RcptUniqueClickRate")]
                [Validation(Required=false)]
                public string RcptUniqueClickRate { get; set; }

                [NameInMap("RcptUniqueOpenCount")]
                [Validation(Required=false)]
                public string RcptUniqueOpenCount { get; set; }

                [NameInMap("RcptUniqueOpenRate")]
                [Validation(Required=false)]
                public string RcptUniqueOpenRate { get; set; }

                [NameInMap("TotalNumber")]
                [Validation(Required=false)]
                public string TotalNumber { get; set; }

            }

        }

    }

}

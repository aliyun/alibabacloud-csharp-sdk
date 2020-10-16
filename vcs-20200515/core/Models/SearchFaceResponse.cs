// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class SearchFaceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public SearchFaceResponseData Data { get; set; }
        public class SearchFaceResponseData : TeaModel {
            [NameInMap("PageNo")]
            [Validation(Required=true)]
            public int? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=true)]
            public int? TotalPage { get; set; }
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<SearchFaceResponseDataRecords> Records { get; set; }
            public class SearchFaceResponseDataRecords : TeaModel {
                public string GbId { get; set; }
                public string ImageUrl { get; set; }
                public float? LeftTopX { get; set; }
                public float? LeftTopY { get; set; }
                public string MatchSuggestion { get; set; }
                public float? RightBottomX { get; set; }
                public float? RightBottomY { get; set; }
                public float? Score { get; set; }
                public string TargetImageUrl { get; set; }
                public string SourceId { get; set; }
            }
        };

    }

}

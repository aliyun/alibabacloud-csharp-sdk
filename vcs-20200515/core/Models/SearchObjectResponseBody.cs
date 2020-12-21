// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class SearchObjectResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchObjectResponseBodyData Data { get; set; }
        public class SearchObjectResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<SearchObjectResponseBodyDataRecords> Records { get; set; }
            public class SearchObjectResponseBodyDataRecords : TeaModel {
                public string DeviceID { get; set; }
                public string CompareResult { get; set; }
                public int? RightBtmX { get; set; }
                public float? Score { get; set; }
                public string SourceImageUrl { get; set; }
                public string SourceID { get; set; }
                public int? RightBtmY { get; set; }
                public string TargetImageUrl { get; set; }
                public int? LeftTopY { get; set; }
                public string TargetImagePath { get; set; }
                public long ShotTime { get; set; }
                public int? LeftTopX { get; set; }
                public string SourceImagePath { get; set; }
            }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}

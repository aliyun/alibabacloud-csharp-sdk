// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class SearchObjectResponse : TeaModel {
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
        public SearchObjectResponseData Data { get; set; }
        public class SearchObjectResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
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
            public List<SearchObjectResponseDataRecords> Records { get; set; }
            public class SearchObjectResponseDataRecords : TeaModel {
                public string CompareResult { get; set; }
                public string DeviceID { get; set; }
                public long ShotTime { get; set; }
                public int? LeftTopX { get; set; }
                public int? LeftTopY { get; set; }
                public int? RightBtmX { get; set; }
                public int? RightBtmY { get; set; }
                public float? Score { get; set; }
                public string SourceID { get; set; }
                public string SourceImagePath { get; set; }
                public string SourceImageUrl { get; set; }
                public string TargetImagePath { get; set; }
                public string TargetImageUrl { get; set; }
            }
        };

    }

}

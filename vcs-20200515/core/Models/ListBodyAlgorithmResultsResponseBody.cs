// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListBodyAlgorithmResultsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListBodyAlgorithmResultsResponseBodyData Data { get; set; }
        public class ListBodyAlgorithmResultsResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListBodyAlgorithmResultsResponseBodyDataRecords> Records { get; set; }
            public class ListBodyAlgorithmResultsResponseBodyDataRecords : TeaModel {
                public float? RightBottomY { get; set; }
                public string DataSourceId { get; set; }
                public string PicUrlPath { get; set; }
                public string TrousersColor { get; set; }
                public float? RightBottomX { get; set; }
                public string CoatColor { get; set; }
                public string SourceId { get; set; }
                public string MaxAge { get; set; }
                public string CoatLength { get; set; }
                public string TargetPicUrlPath { get; set; }
                public string HairStyle { get; set; }
                public string CoatStyle { get; set; }
                public float? LeftTopY { get; set; }
                public string MinAge { get; set; }
                public string CorpId { get; set; }
                public string TrousersLength { get; set; }
                public string TrousersStyle { get; set; }
                public string ShotTime { get; set; }
                public float? LeftTopX { get; set; }
                public string GenderCode { get; set; }
                public string PersonId { get; set; }
                public string CapStyle { get; set; }
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

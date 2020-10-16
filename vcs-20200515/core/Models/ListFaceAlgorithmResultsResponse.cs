// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListFaceAlgorithmResultsResponse : TeaModel {
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
        public ListFaceAlgorithmResultsResponseData Data { get; set; }
        public class ListFaceAlgorithmResultsResponseData : TeaModel {
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
            public List<ListFaceAlgorithmResultsResponseDataRecords> Records { get; set; }
            public class ListFaceAlgorithmResultsResponseDataRecords : TeaModel {
                public string FaceId { get; set; }
                public string CorpId { get; set; }
                public string DataSourceId { get; set; }
                public string ShotTime { get; set; }
                public string GenderCode { get; set; }
                public string MinAge { get; set; }
                public string MaxAge { get; set; }
                public string CapStyle { get; set; }
                public string HairStyle { get; set; }
                public float? LeftTopX { get; set; }
                public float? LeftTopY { get; set; }
                public float? RightBottomX { get; set; }
                public float? RightBottomY { get; set; }
                public string PicUrlPath { get; set; }
                public string TargetPicUrlPath { get; set; }
                public string SourceId { get; set; }
            }
        };

    }

}

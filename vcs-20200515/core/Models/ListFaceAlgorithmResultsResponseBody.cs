// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListFaceAlgorithmResultsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFaceAlgorithmResultsResponseBodyData Data { get; set; }
        public class ListFaceAlgorithmResultsResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListFaceAlgorithmResultsResponseBodyDataRecords> Records { get; set; }
            public class ListFaceAlgorithmResultsResponseBodyDataRecords : TeaModel {
                public float? RightBottomY { get; set; }
                public string DataSourceId { get; set; }
                public string PicUrlPath { get; set; }
                public string FaceId { get; set; }
                public float? RightBottomX { get; set; }
                public string SourceId { get; set; }
                public string MaxAge { get; set; }
                public string TargetPicUrlPath { get; set; }
                public string HairStyle { get; set; }
                public float? LeftTopY { get; set; }
                public string MinAge { get; set; }
                public string CorpId { get; set; }
                public string ShotTime { get; set; }
                public string GenderCode { get; set; }
                public string CapStyle { get; set; }
                public float? LeftTopX { get; set; }
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

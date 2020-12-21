// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListMotorAlgorithmResultsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMotorAlgorithmResultsResponseBodyData Data { get; set; }
        public class ListMotorAlgorithmResultsResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListMotorAlgorithmResultsResponseBodyDataRecords> Records { get; set; }
            public class ListMotorAlgorithmResultsResponseBodyDataRecords : TeaModel {
                public string MotorClass { get; set; }
                public float? RightBottomY { get; set; }
                public string DataSourceId { get; set; }
                public string PicUrlPath { get; set; }
                public string PlateClass { get; set; }
                public string PlateColor { get; set; }
                public float? RightBottomX { get; set; }
                public string SourceId { get; set; }
                public string SafetyBelt { get; set; }
                public string MotorStyle { get; set; }
                public string TargetPicUrlPath { get; set; }
                public float? LeftTopY { get; set; }
                public string MotorColor { get; set; }
                public string PlateNumber { get; set; }
                public string CorpId { get; set; }
                public string ShotTime { get; set; }
                public string Calling { get; set; }
                public float? LeftTopX { get; set; }
                public string MotorBrand { get; set; }
                public string MotorModel { get; set; }
                public string MotorId { get; set; }
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

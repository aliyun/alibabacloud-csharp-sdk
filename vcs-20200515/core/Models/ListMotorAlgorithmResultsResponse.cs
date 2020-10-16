// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListMotorAlgorithmResultsResponse : TeaModel {
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
        public ListMotorAlgorithmResultsResponseData Data { get; set; }
        public class ListMotorAlgorithmResultsResponseData : TeaModel {
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
            public List<ListMotorAlgorithmResultsResponseDataRecords> Records { get; set; }
            public class ListMotorAlgorithmResultsResponseDataRecords : TeaModel {
                public string CorpId { get; set; }
                public string DataSourceId { get; set; }
                public float? LeftTopX { get; set; }
                public float? LeftTopY { get; set; }
                public string MotorId { get; set; }
                public string PicUrlPath { get; set; }
                public string PlateNumber { get; set; }
                public float? RightBottomX { get; set; }
                public float? RightBottomY { get; set; }
                public string ShotTime { get; set; }
                public string TargetPicUrlPath { get; set; }
                public string MotorStyle { get; set; }
                public string MotorModel { get; set; }
                public string MotorColor { get; set; }
                public string MotorClass { get; set; }
                public string MotorBrand { get; set; }
                public string PlateColor { get; set; }
                public string PlateClass { get; set; }
                public string SafetyBelt { get; set; }
                public string Calling { get; set; }
                public string SourceId { get; set; }
            }
        };

    }

}

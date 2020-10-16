// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListEventAlgorithmDetailsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public string Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<ListEventAlgorithmDetailsResponseData> Data { get; set; }
        public class ListEventAlgorithmDetailsResponseData : TeaModel {
            [NameInMap("CorpId")]
            [Validation(Required=true)]
            public string CorpId { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=true)]
            public string DataSourceId { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=true)]
            public string EventType { get; set; }

            [NameInMap("EventValue")]
            [Validation(Required=true)]
            public string EventValue { get; set; }

            [NameInMap("ExtendValue")]
            [Validation(Required=true)]
            public string ExtendValue { get; set; }

            [NameInMap("ExtraExtendValue")]
            [Validation(Required=true)]
            public string ExtraExtendValue { get; set; }

            [NameInMap("FaceCount")]
            [Validation(Required=true)]
            public string FaceCount { get; set; }

            [NameInMap("LeftTopX")]
            [Validation(Required=true)]
            public string LeftTopX { get; set; }

            [NameInMap("LeftTopY")]
            [Validation(Required=true)]
            public string LeftTopY { get; set; }

            [NameInMap("PicUrlPath")]
            [Validation(Required=true)]
            public string PicUrlPath { get; set; }

            [NameInMap("PointX")]
            [Validation(Required=true)]
            public string PointX { get; set; }

            [NameInMap("PointY")]
            [Validation(Required=true)]
            public string PointY { get; set; }

            [NameInMap("RecordId")]
            [Validation(Required=true)]
            public string RecordId { get; set; }

            [NameInMap("RightBottomX")]
            [Validation(Required=true)]
            public string RightBottomX { get; set; }

            [NameInMap("RightBottomY")]
            [Validation(Required=true)]
            public string RightBottomY { get; set; }

            [NameInMap("ShotTime")]
            [Validation(Required=true)]
            public string ShotTime { get; set; }

            [NameInMap("SourceId")]
            [Validation(Required=true)]
            public string SourceId { get; set; }

            [NameInMap("TargetPicUrlPath")]
            [Validation(Required=true)]
            public string TargetPicUrlPath { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListEventAlgorithmDetailsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEventAlgorithmDetailsResponseBodyData> Data { get; set; }
        public class ListEventAlgorithmDetailsResponseBodyData : TeaModel {
            [NameInMap("RightBottomY")]
            [Validation(Required=false)]
            public string RightBottomY { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("PicUrlPath")]
            [Validation(Required=false)]
            public string PicUrlPath { get; set; }

            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("ExtendValue")]
            [Validation(Required=false)]
            public string ExtendValue { get; set; }

            [NameInMap("FaceCount")]
            [Validation(Required=false)]
            public string FaceCount { get; set; }

            [NameInMap("RightBottomX")]
            [Validation(Required=false)]
            public string RightBottomX { get; set; }

            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            [NameInMap("ExtraExtendValue")]
            [Validation(Required=false)]
            public string ExtraExtendValue { get; set; }

            [NameInMap("TargetPicUrlPath")]
            [Validation(Required=false)]
            public string TargetPicUrlPath { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("PointY")]
            [Validation(Required=false)]
            public string PointY { get; set; }

            [NameInMap("LeftTopY")]
            [Validation(Required=false)]
            public string LeftTopY { get; set; }

            [NameInMap("PointX")]
            [Validation(Required=false)]
            public string PointX { get; set; }

            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("EventValue")]
            [Validation(Required=false)]
            public string EventValue { get; set; }

            [NameInMap("ShotTime")]
            [Validation(Required=false)]
            public string ShotTime { get; set; }

            [NameInMap("LeftTopX")]
            [Validation(Required=false)]
            public string LeftTopX { get; set; }

            [NameInMap("TagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

            [NameInMap("TagCodeReliability")]
            [Validation(Required=false)]
            public string TagCodeReliability { get; set; }

            [NameInMap("UuidCode")]
            [Validation(Required=false)]
            public string UuidCode { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}

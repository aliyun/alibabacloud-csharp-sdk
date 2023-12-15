// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListPersonTrackResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPersonTrackResponseBodyData> Data { get; set; }
        public class ListPersonTrackResponseBodyData : TeaModel {
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("LeftTopX")]
            [Validation(Required=false)]
            public string LeftTopX { get; set; }

            [NameInMap("LeftTopY")]
            [Validation(Required=false)]
            public string LeftTopY { get; set; }

            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("PersonId")]
            [Validation(Required=false)]
            public string PersonId { get; set; }

            [NameInMap("PicUrlPath")]
            [Validation(Required=false)]
            public string PicUrlPath { get; set; }

            [NameInMap("RightBottomX")]
            [Validation(Required=false)]
            public string RightBottomX { get; set; }

            [NameInMap("RightBottomY")]
            [Validation(Required=false)]
            public string RightBottomY { get; set; }

            [NameInMap("ShotTime")]
            [Validation(Required=false)]
            public string ShotTime { get; set; }

            [NameInMap("SourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            [NameInMap("TagAge")]
            [Validation(Required=false)]
            public string TagAge { get; set; }

            [NameInMap("TagGender")]
            [Validation(Required=false)]
            public string TagGender { get; set; }

            [NameInMap("TargetPicUrlPath")]
            [Validation(Required=false)]
            public string TargetPicUrlPath { get; set; }

            [NameInMap("TargetUrl")]
            [Validation(Required=false)]
            public string TargetUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class SearchObjectResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchObjectResponseBodyData Data { get; set; }
        public class SearchObjectResponseBodyData : TeaModel {
            [NameInMap("BodyList")]
            [Validation(Required=false)]
            public List<SearchObjectResponseBodyDataBodyList> BodyList { get; set; }
            public class SearchObjectResponseBodyDataBodyList : TeaModel {
                public string SourceImageUrl { get; set; }
                public string DeviceID { get; set; }
                public string ObjectType { get; set; }
                public string TargetImageUrl { get; set; }
                public int? RightBottomY { get; set; }
                public int? LeftTopY { get; set; }
                public float? Score { get; set; }
                public string ShotTime { get; set; }
                public int? RightBottomX { get; set; }
                public int? LeftTopX { get; set; }
            }
            [NameInMap("FaceList")]
            [Validation(Required=false)]
            public List<SearchObjectResponseBodyDataFaceList> FaceList { get; set; }
            public class SearchObjectResponseBodyDataFaceList : TeaModel {
                public string SourceImageUrl { get; set; }
                public string DeviceID { get; set; }
                public string ObjectType { get; set; }
                public string TargetImageUrl { get; set; }
                public int? RightBottomY { get; set; }
                public int? LeftTopY { get; set; }
                public float? Score { get; set; }
                public string ShotTime { get; set; }
                public int? RightBottomX { get; set; }
                public int? LeftTopX { get; set; }
            }
            [NameInMap("MotorList")]
            [Validation(Required=false)]
            public List<SearchObjectResponseBodyDataMotorList> MotorList { get; set; }
            public class SearchObjectResponseBodyDataMotorList : TeaModel {
                public string SourceImageUrl { get; set; }
                public string DeviceID { get; set; }
                public string ObjectType { get; set; }
                public string TargetImageUrl { get; set; }
                public int? RightBottomY { get; set; }
                public int? LeftTopY { get; set; }
                public float? Score { get; set; }
                public string ShotTime { get; set; }
                public int? RightBottomX { get; set; }
                public int? LeftTopX { get; set; }
            }
            [NameInMap("NonMotorList")]
            [Validation(Required=false)]
            public List<SearchObjectResponseBodyDataNonMotorList> NonMotorList { get; set; }
            public class SearchObjectResponseBodyDataNonMotorList : TeaModel {
                public string SourceImageUrl { get; set; }
                public string DeviceID { get; set; }
                public string ObjectType { get; set; }
                public string TargetImageUrl { get; set; }
                public int? RightBottomY { get; set; }
                public int? LeftTopY { get; set; }
                public float? Score { get; set; }
                public string ShotTime { get; set; }
                public int? RightBottomX { get; set; }
                public int? LeftTopX { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

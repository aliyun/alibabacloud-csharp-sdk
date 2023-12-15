// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class SearchObjectResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchObjectResponseBodyData Data { get; set; }
        public class SearchObjectResponseBodyData : TeaModel {
            [NameInMap("BodyList")]
            [Validation(Required=false)]
            public List<SearchObjectResponseBodyDataBodyList> BodyList { get; set; }
            public class SearchObjectResponseBodyDataBodyList : TeaModel {
                [NameInMap("DeviceID")]
                [Validation(Required=false)]
                public string DeviceID { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("RightBottomX")]
                [Validation(Required=false)]
                public int? RightBottomX { get; set; }

                [NameInMap("RightBottomY")]
                [Validation(Required=false)]
                public int? RightBottomY { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("ShotTime")]
                [Validation(Required=false)]
                public string ShotTime { get; set; }

                [NameInMap("SourceImageUrl")]
                [Validation(Required=false)]
                public string SourceImageUrl { get; set; }

                [NameInMap("TargetImageUrl")]
                [Validation(Required=false)]
                public string TargetImageUrl { get; set; }

            }

            [NameInMap("FaceList")]
            [Validation(Required=false)]
            public List<SearchObjectResponseBodyDataFaceList> FaceList { get; set; }
            public class SearchObjectResponseBodyDataFaceList : TeaModel {
                [NameInMap("DeviceID")]
                [Validation(Required=false)]
                public string DeviceID { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("RightBottomX")]
                [Validation(Required=false)]
                public int? RightBottomX { get; set; }

                [NameInMap("RightBottomY")]
                [Validation(Required=false)]
                public int? RightBottomY { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("ShotTime")]
                [Validation(Required=false)]
                public string ShotTime { get; set; }

                [NameInMap("SourceImageUrl")]
                [Validation(Required=false)]
                public string SourceImageUrl { get; set; }

                [NameInMap("TargetImageUrl")]
                [Validation(Required=false)]
                public string TargetImageUrl { get; set; }

            }

            [NameInMap("MotorList")]
            [Validation(Required=false)]
            public List<SearchObjectResponseBodyDataMotorList> MotorList { get; set; }
            public class SearchObjectResponseBodyDataMotorList : TeaModel {
                [NameInMap("DeviceID")]
                [Validation(Required=false)]
                public string DeviceID { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("RightBottomX")]
                [Validation(Required=false)]
                public int? RightBottomX { get; set; }

                [NameInMap("RightBottomY")]
                [Validation(Required=false)]
                public int? RightBottomY { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("ShotTime")]
                [Validation(Required=false)]
                public string ShotTime { get; set; }

                [NameInMap("SourceImageUrl")]
                [Validation(Required=false)]
                public string SourceImageUrl { get; set; }

                [NameInMap("TargetImageUrl")]
                [Validation(Required=false)]
                public string TargetImageUrl { get; set; }

            }

            [NameInMap("NonMotorList")]
            [Validation(Required=false)]
            public List<SearchObjectResponseBodyDataNonMotorList> NonMotorList { get; set; }
            public class SearchObjectResponseBodyDataNonMotorList : TeaModel {
                [NameInMap("DeviceID")]
                [Validation(Required=false)]
                public string DeviceID { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("RightBottomX")]
                [Validation(Required=false)]
                public int? RightBottomX { get; set; }

                [NameInMap("RightBottomY")]
                [Validation(Required=false)]
                public int? RightBottomY { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("ShotTime")]
                [Validation(Required=false)]
                public string ShotTime { get; set; }

                [NameInMap("SourceImageUrl")]
                [Validation(Required=false)]
                public string SourceImageUrl { get; set; }

                [NameInMap("TargetImageUrl")]
                [Validation(Required=false)]
                public string TargetImageUrl { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

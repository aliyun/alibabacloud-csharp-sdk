// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class SearchAggregateObjectResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchAggregateObjectResponseBodyData Data { get; set; }
        public class SearchAggregateObjectResponseBodyData : TeaModel {
            [NameInMap("BodyList")]
            [Validation(Required=false)]
            public List<SearchAggregateObjectResponseBodyDataBodyList> BodyList { get; set; }
            public class SearchAggregateObjectResponseBodyDataBodyList : TeaModel {
                [NameInMap("DeviceID")]
                [Validation(Required=false)]
                public string DeviceID { get; set; }

                [NameInMap("DeviceLatitude")]
                [Validation(Required=false)]
                public float? DeviceLatitude { get; set; }

                [NameInMap("DeviceLongitude")]
                [Validation(Required=false)]
                public float? DeviceLongitude { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("PersonId")]
                [Validation(Required=false)]
                public string PersonId { get; set; }

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
            public List<SearchAggregateObjectResponseBodyDataFaceList> FaceList { get; set; }
            public class SearchAggregateObjectResponseBodyDataFaceList : TeaModel {
                [NameInMap("DeviceID")]
                [Validation(Required=false)]
                public string DeviceID { get; set; }

                [NameInMap("DeviceLatitude")]
                [Validation(Required=false)]
                public float? DeviceLatitude { get; set; }

                [NameInMap("DeviceLongitude")]
                [Validation(Required=false)]
                public float? DeviceLongitude { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("PersonId")]
                [Validation(Required=false)]
                public string PersonId { get; set; }

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
            public List<SearchAggregateObjectResponseBodyDataMotorList> MotorList { get; set; }
            public class SearchAggregateObjectResponseBodyDataMotorList : TeaModel {
                [NameInMap("DeviceID")]
                [Validation(Required=false)]
                public string DeviceID { get; set; }

                [NameInMap("DeviceLatitude")]
                [Validation(Required=false)]
                public float? DeviceLatitude { get; set; }

                [NameInMap("DeviceLongitude")]
                [Validation(Required=false)]
                public float? DeviceLongitude { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("PersonId")]
                [Validation(Required=false)]
                public string PersonId { get; set; }

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
            public List<SearchAggregateObjectResponseBodyDataNonMotorList> NonMotorList { get; set; }
            public class SearchAggregateObjectResponseBodyDataNonMotorList : TeaModel {
                [NameInMap("DeviceID")]
                [Validation(Required=false)]
                public string DeviceID { get; set; }

                [NameInMap("DeviceLatitude")]
                [Validation(Required=false)]
                public float? DeviceLatitude { get; set; }

                [NameInMap("DeviceLongitude")]
                [Validation(Required=false)]
                public float? DeviceLongitude { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("LeftTopX")]
                [Validation(Required=false)]
                public int? LeftTopX { get; set; }

                [NameInMap("LeftTopY")]
                [Validation(Required=false)]
                public int? LeftTopY { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("PersonId")]
                [Validation(Required=false)]
                public string PersonId { get; set; }

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

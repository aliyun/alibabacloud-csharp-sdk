// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class SearchAggregateObjectResponseBody : TeaModel {
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
        public SearchAggregateObjectResponseBodyData Data { get; set; }
        public class SearchAggregateObjectResponseBodyData : TeaModel {
            [NameInMap("BodyList")]
            [Validation(Required=false)]
            public List<SearchAggregateObjectResponseBodyDataBodyList> BodyList { get; set; }
            public class SearchAggregateObjectResponseBodyDataBodyList : TeaModel {
                public string DeviceID { get; set; }
                public string ObjectType { get; set; }
                public string DeviceName { get; set; }
                public int? RightBottomY { get; set; }
                public float? Score { get; set; }
                public int? RightBottomX { get; set; }
                public float? DeviceLongitude { get; set; }
                public string SourceImageUrl { get; set; }
                public string TargetImageUrl { get; set; }
                public int? LeftTopY { get; set; }
                public string ShotTime { get; set; }
                public string PersonId { get; set; }
                public int? LeftTopX { get; set; }
                public float? DeviceLatitude { get; set; }
            }
            [NameInMap("FaceList")]
            [Validation(Required=false)]
            public List<SearchAggregateObjectResponseBodyDataFaceList> FaceList { get; set; }
            public class SearchAggregateObjectResponseBodyDataFaceList : TeaModel {
                public string DeviceID { get; set; }
                public string ObjectType { get; set; }
                public string DeviceName { get; set; }
                public int? RightBottomY { get; set; }
                public float? Score { get; set; }
                public int? RightBottomX { get; set; }
                public float? DeviceLongitude { get; set; }
                public string SourceImageUrl { get; set; }
                public string TargetImageUrl { get; set; }
                public int? LeftTopY { get; set; }
                public string ShotTime { get; set; }
                public string PersonId { get; set; }
                public int? LeftTopX { get; set; }
                public float? DeviceLatitude { get; set; }
            }
            [NameInMap("MotorList")]
            [Validation(Required=false)]
            public List<SearchAggregateObjectResponseBodyDataMotorList> MotorList { get; set; }
            public class SearchAggregateObjectResponseBodyDataMotorList : TeaModel {
                public string DeviceID { get; set; }
                public string ObjectType { get; set; }
                public string DeviceName { get; set; }
                public int? RightBottomY { get; set; }
                public float? Score { get; set; }
                public int? RightBottomX { get; set; }
                public float? DeviceLongitude { get; set; }
                public string SourceImageUrl { get; set; }
                public string TargetImageUrl { get; set; }
                public int? LeftTopY { get; set; }
                public string ShotTime { get; set; }
                public string PersonId { get; set; }
                public int? LeftTopX { get; set; }
                public float? DeviceLatitude { get; set; }
            }
            [NameInMap("NonMotorList")]
            [Validation(Required=false)]
            public List<SearchAggregateObjectResponseBodyDataNonMotorList> NonMotorList { get; set; }
            public class SearchAggregateObjectResponseBodyDataNonMotorList : TeaModel {
                public string DeviceID { get; set; }
                public string ObjectType { get; set; }
                public string DeviceName { get; set; }
                public int? RightBottomY { get; set; }
                public float? Score { get; set; }
                public int? RightBottomX { get; set; }
                public float? DeviceLongitude { get; set; }
                public string SourceImageUrl { get; set; }
                public string TargetImageUrl { get; set; }
                public int? LeftTopY { get; set; }
                public string ShotTime { get; set; }
                public string PersonId { get; set; }
                public int? LeftTopX { get; set; }
                public float? DeviceLatitude { get; set; }
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

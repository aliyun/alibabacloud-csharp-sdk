// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class SearchImagesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Images")]
        [Validation(Required=false)]
        public SearchImagesResponseBodyImages Images { get; set; }
        public class SearchImagesResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<SearchImagesResponseBodyImagesImage> Image { get; set; }
            public class SearchImagesResponseBodyImagesImage : TeaModel {
                public string CameraId { get; set; }
                public float? TrouserTypeScore { get; set; }
                public string ObjType { get; set; }
                public string TrouserColor { get; set; }
                public float? ClothTypeScore { get; set; }
                public string Brand { get; set; }
                public string PoseType { get; set; }
                public string VehicleColor { get; set; }
                public int? ObjLeft { get; set; }
                public float? Score { get; set; }
                public float? HeadWearScore { get; set; }
                public float? AgeTypeScore { get; set; }
                public float? SexTypeScore { get; set; }
                public string NonVehicleType { get; set; }
                public int? ObjBottom { get; set; }
                public string PlateNumber { get; set; }
                public string ClothType { get; set; }
                public string TimeStamp { get; set; }
                public string OrigImage { get; set; }
                public float? VehicleTypeScore { get; set; }
                public float? TrouserColorScore { get; set; }
                public string ImageId { get; set; }
                public float? VehicleColorScore { get; set; }
                public float? HairTypeScore { get; set; }
                public string HairType { get; set; }
                public float? NonVehicleTypeScore { get; set; }
                public string HeadWear { get; set; }
                public string VehicleType { get; set; }
                public string SexType { get; set; }
                public float? PoseTypeScore { get; set; }
                public int? ObjRight { get; set; }
                public string Feature { get; set; }
                public float? ClothColorScore { get; set; }
                public string CropImage { get; set; }
                public int? ObjTop { get; set; }
                public float? BrandScore { get; set; }
                public string ClothColor { get; set; }
                public string AgeType { get; set; }
                public string LeaveTime { get; set; }
                public string TrouserType { get; set; }
                public string EntryTime { get; set; }
            }
        };

    }

}

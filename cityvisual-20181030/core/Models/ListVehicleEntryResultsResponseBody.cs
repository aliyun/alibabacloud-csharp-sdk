// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class ListVehicleEntryResultsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<ListVehicleEntryResultsResponseBodyResults> Results { get; set; }
        public class ListVehicleEntryResultsResponseBodyResults : TeaModel {
            [NameInMap("CameraId")]
            [Validation(Required=false)]
            public string CameraId { get; set; }

            [NameInMap("ObjRight")]
            [Validation(Required=false)]
            public int? ObjRight { get; set; }

            [NameInMap("ObjType")]
            [Validation(Required=false)]
            public string ObjType { get; set; }

            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            [NameInMap("PlateLeft")]
            [Validation(Required=false)]
            public int? PlateLeft { get; set; }

            [NameInMap("ObjLeft")]
            [Validation(Required=false)]
            public int? ObjLeft { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            [NameInMap("CropImage")]
            [Validation(Required=false)]
            public string CropImage { get; set; }

            [NameInMap("ObjTop")]
            [Validation(Required=false)]
            public int? ObjTop { get; set; }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("PlateBottom")]
            [Validation(Required=false)]
            public int? PlateBottom { get; set; }

            [NameInMap("LeaveTime")]
            [Validation(Required=false)]
            public string LeaveTime { get; set; }

            [NameInMap("PlateTop")]
            [Validation(Required=false)]
            public int? PlateTop { get; set; }

            [NameInMap("ObjBottom")]
            [Validation(Required=false)]
            public int? ObjBottom { get; set; }

            [NameInMap("PlateRight")]
            [Validation(Required=false)]
            public int? PlateRight { get; set; }

            [NameInMap("OrigImage")]
            [Validation(Required=false)]
            public string OrigImage { get; set; }

            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            [NameInMap("VehiclePlate")]
            [Validation(Required=false)]
            public string VehiclePlate { get; set; }

            [NameInMap("EntryTime")]
            [Validation(Required=false)]
            public string EntryTime { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

        }

    }

}

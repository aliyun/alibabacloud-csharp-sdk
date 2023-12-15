// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListCityMapImageDetailsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCityMapImageDetailsResponseBodyData> Data { get; set; }
        public class ListCityMapImageDetailsResponseBodyData : TeaModel {
            [NameInMap("AgeCodeReliability")]
            [Validation(Required=false)]
            public string AgeCodeReliability { get; set; }

            [NameInMap("AgeLowerLimit")]
            [Validation(Required=false)]
            public string AgeLowerLimit { get; set; }

            [NameInMap("AgeLowerLimitReliability")]
            [Validation(Required=false)]
            public string AgeLowerLimitReliability { get; set; }

            [NameInMap("AgeUpLimit")]
            [Validation(Required=false)]
            public string AgeUpLimit { get; set; }

            [NameInMap("CoatColor")]
            [Validation(Required=false)]
            public string CoatColor { get; set; }

            [NameInMap("CoatColorReliability")]
            [Validation(Required=false)]
            public string CoatColorReliability { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("FaceTargetImageStoragePath")]
            [Validation(Required=false)]
            public string FaceTargetImageStoragePath { get; set; }

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("GenderCodeReliability")]
            [Validation(Required=false)]
            public string GenderCodeReliability { get; set; }

            [NameInMap("LeftTopX")]
            [Validation(Required=false)]
            public string LeftTopX { get; set; }

            [NameInMap("LeftTopY")]
            [Validation(Required=false)]
            public string LeftTopY { get; set; }

            [NameInMap("MotorTargetImageStoragePath")]
            [Validation(Required=false)]
            public string MotorTargetImageStoragePath { get; set; }

            [NameInMap("PersonTargetImageStoragePath")]
            [Validation(Required=false)]
            public string PersonTargetImageStoragePath { get; set; }

            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("RightBottomX")]
            [Validation(Required=false)]
            public string RightBottomX { get; set; }

            [NameInMap("RightBottomY")]
            [Validation(Required=false)]
            public string RightBottomY { get; set; }

            [NameInMap("ShotTime")]
            [Validation(Required=false)]
            public string ShotTime { get; set; }

            [NameInMap("SourceImageStoragePath")]
            [Validation(Required=false)]
            public string SourceImageStoragePath { get; set; }

            [NameInMap("TrousersColor")]
            [Validation(Required=false)]
            public string TrousersColor { get; set; }

            [NameInMap("TrousersColorReliability")]
            [Validation(Required=false)]
            public string TrousersColorReliability { get; set; }

            [NameInMap("VehicleClass")]
            [Validation(Required=false)]
            public string VehicleClass { get; set; }

            [NameInMap("VehicleClassReliability")]
            [Validation(Required=false)]
            public string VehicleClassReliability { get; set; }

            [NameInMap("VehicleColor")]
            [Validation(Required=false)]
            public string VehicleColor { get; set; }

            [NameInMap("VehicleColorReliability")]
            [Validation(Required=false)]
            public string VehicleColorReliability { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeDrivingLicenseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeDrivingLicenseResponseBodyData Data { get; set; }
        public class RecognizeDrivingLicenseResponseBodyData : TeaModel {
            [NameInMap("BackResult")]
            [Validation(Required=false)]
            public RecognizeDrivingLicenseResponseBodyDataBackResult BackResult { get; set; }
            public class RecognizeDrivingLicenseResponseBodyDataBackResult : TeaModel {
                [NameInMap("ApprovedLoad")]
                [Validation(Required=false)]
                public string ApprovedLoad { get; set; }

                [NameInMap("ApprovedPassengerCapacity")]
                [Validation(Required=false)]
                public string ApprovedPassengerCapacity { get; set; }

                [NameInMap("EnergyType")]
                [Validation(Required=false)]
                public string EnergyType { get; set; }

                [NameInMap("FileNumber")]
                [Validation(Required=false)]
                public string FileNumber { get; set; }

                [NameInMap("GrossMass")]
                [Validation(Required=false)]
                public string GrossMass { get; set; }

                [NameInMap("InspectionRecord")]
                [Validation(Required=false)]
                public string InspectionRecord { get; set; }

                [NameInMap("OverallDimension")]
                [Validation(Required=false)]
                public string OverallDimension { get; set; }

                [NameInMap("PlateNumber")]
                [Validation(Required=false)]
                public string PlateNumber { get; set; }

                [NameInMap("TractionMass")]
                [Validation(Required=false)]
                public string TractionMass { get; set; }

                [NameInMap("UnladenMass")]
                [Validation(Required=false)]
                public string UnladenMass { get; set; }

            }
            [NameInMap("FaceResult")]
            [Validation(Required=false)]
            public RecognizeDrivingLicenseResponseBodyDataFaceResult FaceResult { get; set; }
            public class RecognizeDrivingLicenseResponseBodyDataFaceResult : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("EngineNumber")]
                [Validation(Required=false)]
                public string EngineNumber { get; set; }

                [NameInMap("IssueDate")]
                [Validation(Required=false)]
                public string IssueDate { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("PlateNumber")]
                [Validation(Required=false)]
                public string PlateNumber { get; set; }

                [NameInMap("RegisterDate")]
                [Validation(Required=false)]
                public string RegisterDate { get; set; }

                [NameInMap("UseCharacter")]
                [Validation(Required=false)]
                public string UseCharacter { get; set; }

                [NameInMap("VehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }

                [NameInMap("Vin")]
                [Validation(Required=false)]
                public string Vin { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeDriverLicenseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeDriverLicenseResponseBodyData Data { get; set; }
        public class RecognizeDriverLicenseResponseBodyData : TeaModel {
            [NameInMap("BackResult")]
            [Validation(Required=false)]
            public RecognizeDriverLicenseResponseBodyDataBackResult BackResult { get; set; }
            public class RecognizeDriverLicenseResponseBodyDataBackResult : TeaModel {
                [NameInMap("ArchiveNumber")]
                [Validation(Required=false)]
                public string ArchiveNumber { get; set; }

                [NameInMap("CardNumber")]
                [Validation(Required=false)]
                public string CardNumber { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Record")]
                [Validation(Required=false)]
                public string Record { get; set; }

            }

            [NameInMap("FaceResult")]
            [Validation(Required=false)]
            public RecognizeDriverLicenseResponseBodyDataFaceResult FaceResult { get; set; }
            public class RecognizeDriverLicenseResponseBodyDataFaceResult : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("BirthDate")]
                [Validation(Required=false)]
                public string BirthDate { get; set; }

                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                [NameInMap("IssueDate")]
                [Validation(Required=false)]
                public string IssueDate { get; set; }

                [NameInMap("IssueUnit")]
                [Validation(Required=false)]
                public string IssueUnit { get; set; }

                [NameInMap("LicenseNumber")]
                [Validation(Required=false)]
                public string LicenseNumber { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                [NameInMap("VehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

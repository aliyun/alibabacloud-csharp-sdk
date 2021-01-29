// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeBusinessLicenseResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeBusinessLicenseResponseBodyData Data { get; set; }
        public class RecognizeBusinessLicenseResponseBodyData : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Stamp")]
            [Validation(Required=false)]
            public RecognizeBusinessLicenseResponseBodyDataStamp Stamp { get; set; }
            public class RecognizeBusinessLicenseResponseBodyDataStamp : TeaModel {
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

            }
            [NameInMap("EstablishDate")]
            [Validation(Required=false)]
            public string EstablishDate { get; set; }
            [NameInMap("ValidPeriod")]
            [Validation(Required=false)]
            public string ValidPeriod { get; set; }
            [NameInMap("Business")]
            [Validation(Required=false)]
            public string Business { get; set; }
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public float? Angle { get; set; }
            [NameInMap("RegisterNumber")]
            [Validation(Required=false)]
            public string RegisterNumber { get; set; }
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }
            [NameInMap("Capital")]
            [Validation(Required=false)]
            public string Capital { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public RecognizeBusinessLicenseResponseBodyDataTitle Title { get; set; }
            public class RecognizeBusinessLicenseResponseBodyDataTitle : TeaModel {
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

            }
            [NameInMap("Emblem")]
            [Validation(Required=false)]
            public RecognizeBusinessLicenseResponseBodyDataEmblem Emblem { get; set; }
            public class RecognizeBusinessLicenseResponseBodyDataEmblem : TeaModel {
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("QRCode")]
            [Validation(Required=false)]
            public RecognizeBusinessLicenseResponseBodyDataQRCode QRCode { get; set; }
            public class RecognizeBusinessLicenseResponseBodyDataQRCode : TeaModel {
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

            }
            [NameInMap("LegalPerson")]
            [Validation(Required=false)]
            public string LegalPerson { get; set; }
        };

    }

}

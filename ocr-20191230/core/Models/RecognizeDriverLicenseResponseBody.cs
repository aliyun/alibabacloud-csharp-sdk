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
                /// <summary>
                /// <b>Example:</b>
                /// <para>130601473955</para>
                /// </summary>
                [NameInMap("ArchiveNumber")]
                [Validation(Required=false)]
                public string ArchiveNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>210288898898898888</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>20190201</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("Gender")]
                [Validation(Required=false)]
                public string Gender { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20130208</para>
                /// </summary>
                [NameInMap("IssueDate")]
                [Validation(Required=false)]
                public string IssueDate { get; set; }

                [NameInMap("IssueUnit")]
                [Validation(Required=false)]
                public string IssueUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>210288898898898888</para>
                /// </summary>
                [NameInMap("LicenseNumber")]
                [Validation(Required=false)]
                public string LicenseNumber { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20130208</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>C1</para>
                /// </summary>
                [NameInMap("VehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>374D8C7E-9ECC-4750-A87F-50571702F175</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

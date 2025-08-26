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
                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("ApprovedLoad")]
                [Validation(Required=false)]
                public string ApprovedLoad { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ApprovedPassengerCapacity")]
                [Validation(Required=false)]
                public string ApprovedPassengerCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("EnergyType")]
                [Validation(Required=false)]
                public string EnergyType { get; set; }

                [NameInMap("FileNumber")]
                [Validation(Required=false)]
                public string FileNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2205</para>
                /// </summary>
                [NameInMap("GrossMass")]
                [Validation(Required=false)]
                public string GrossMass { get; set; }

                [NameInMap("InspectionRecord")]
                [Validation(Required=false)]
                public string InspectionRecord { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4945x1845x1480</para>
                /// </summary>
                [NameInMap("OverallDimension")]
                [Validation(Required=false)]
                public string OverallDimension { get; set; }

                [NameInMap("PlateNumber")]
                [Validation(Required=false)]
                public string PlateNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TractionMass")]
                [Validation(Required=false)]
                public string TractionMass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>111111</para>
                /// </summary>
                [NameInMap("EngineNumber")]
                [Validation(Required=false)]
                public string EngineNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20180313</para>
                /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>20180312</para>
                /// </summary>
                [NameInMap("RegisterDate")]
                [Validation(Required=false)]
                public string RegisterDate { get; set; }

                [NameInMap("UseCharacter")]
                [Validation(Required=false)]
                public string UseCharacter { get; set; }

                [NameInMap("VehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SSVUDDTT2J2022555</para>
                /// </summary>
                [NameInMap("Vin")]
                [Validation(Required=false)]
                public string Vin { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1DD989C1-4E08-4E04-9D5D-314901E91226</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

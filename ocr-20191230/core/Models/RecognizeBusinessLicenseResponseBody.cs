// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr20191230.Models
{
    public class RecognizeBusinessLicenseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeBusinessLicenseResponseBodyData Data { get; set; }
        public class RecognizeBusinessLicenseResponseBodyData : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Angle")]
            [Validation(Required=false)]
            public float? Angle { get; set; }

            [NameInMap("Business")]
            [Validation(Required=false)]
            public string Business { get; set; }

            [NameInMap("Capital")]
            [Validation(Required=false)]
            public string Capital { get; set; }

            [NameInMap("Emblem")]
            [Validation(Required=false)]
            public RecognizeBusinessLicenseResponseBodyDataEmblem Emblem { get; set; }
            public class RecognizeBusinessLicenseResponseBodyDataEmblem : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>163</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>366</para>
                /// </summary>
                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>162</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20150504</para>
            /// </summary>
            [NameInMap("EstablishDate")]
            [Validation(Required=false)]
            public string EstablishDate { get; set; }

            [NameInMap("LegalPerson")]
            [Validation(Required=false)]
            public string LegalPerson { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("QRCode")]
            [Validation(Required=false)]
            public RecognizeBusinessLicenseResponseBodyDataQRCode QRCode { get; set; }
            public class RecognizeBusinessLicenseResponseBodyDataQRCode : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>132</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>156</para>
                /// </summary>
                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>914</para>
                /// </summary>
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>126</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>91500108320423****</para>
            /// </summary>
            [NameInMap("RegisterNumber")]
            [Validation(Required=false)]
            public string RegisterNumber { get; set; }

            [NameInMap("Stamp")]
            [Validation(Required=false)]
            public RecognizeBusinessLicenseResponseBodyDataStamp Stamp { get; set; }
            public class RecognizeBusinessLicenseResponseBodyDataStamp : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>154</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>650</para>
                /// </summary>
                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1030</para>
                /// </summary>
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>154</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public RecognizeBusinessLicenseResponseBodyDataTitle Title { get; set; }
            public class RecognizeBusinessLicenseResponseBodyDataTitle : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public int? Height { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public int? Width { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>29991231</para>
            /// </summary>
            [NameInMap("ValidPeriod")]
            [Validation(Required=false)]
            public string ValidPeriod { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F34D031B-02BD-4A59-BA35-EE068DD6F6E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeAllTextRequest : TeaModel {
        [NameInMap("AdvancedConfig")]
        [Validation(Required=false)]
        public RecognizeAllTextRequestAdvancedConfig AdvancedConfig { get; set; }
        public class RecognizeAllTextRequestAdvancedConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsHandWritingTable")]
            [Validation(Required=false)]
            public bool? IsHandWritingTable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsLineLessTable")]
            [Validation(Required=false)]
            public bool? IsLineLessTable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OutputCharInfo")]
            [Validation(Required=false)]
            public bool? OutputCharInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OutputParagraph")]
            [Validation(Required=false)]
            public bool? OutputParagraph { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OutputRow")]
            [Validation(Required=false)]
            public bool? OutputRow { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OutputTable")]
            [Validation(Required=false)]
            public bool? OutputTable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OutputTableExcel")]
            [Validation(Required=false)]
            public bool? OutputTableExcel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OutputTableHtml")]
            [Validation(Required=false)]
            public bool? OutputTableHtml { get; set; }

        }

        [NameInMap("IdCardConfig")]
        [Validation(Required=false)]
        public RecognizeAllTextRequestIdCardConfig IdCardConfig { get; set; }
        public class RecognizeAllTextRequestIdCardConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OutputIdCardQuality")]
            [Validation(Required=false)]
            public bool? OutputIdCardQuality { get; set; }

        }

        [NameInMap("InternationalBusinessLicenseConfig")]
        [Validation(Required=false)]
        public RecognizeAllTextRequestInternationalBusinessLicenseConfig InternationalBusinessLicenseConfig { get; set; }
        public class RecognizeAllTextRequestInternationalBusinessLicenseConfig : TeaModel {
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

        }

        [NameInMap("InternationalIdCardConfig")]
        [Validation(Required=false)]
        public RecognizeAllTextRequestInternationalIdCardConfig InternationalIdCardConfig { get; set; }
        public class RecognizeAllTextRequestInternationalIdCardConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>India</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

        }

        [NameInMap("MultiLanConfig")]
        [Validation(Required=false)]
        public RecognizeAllTextRequestMultiLanConfig MultiLanConfig { get; set; }
        public class RecognizeAllTextRequestMultiLanConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>eng,chn</para>
            /// </summary>
            [NameInMap("Languages")]
            [Validation(Required=false)]
            public string Languages { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OutputBarCode")]
        [Validation(Required=false)]
        public bool? OutputBarCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OutputCoordinate")]
        [Validation(Required=false)]
        public string OutputCoordinate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("OutputFigure")]
        [Validation(Required=false)]
        public bool? OutputFigure { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OutputKVExcel")]
        [Validation(Required=false)]
        public bool? OutputKVExcel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OutputOricoord")]
        [Validation(Required=false)]
        public bool? OutputOricoord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("OutputQrcode")]
        [Validation(Required=false)]
        public bool? OutputQrcode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("OutputStamp")]
        [Validation(Required=false)]
        public bool? OutputStamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("TableConfig")]
        [Validation(Required=false)]
        public RecognizeAllTextRequestTableConfig TableConfig { get; set; }
        public class RecognizeAllTextRequestTableConfig : TeaModel {
            [NameInMap("IsHandWritingTable")]
            [Validation(Required=false)]
            public bool? IsHandWritingTable { get; set; }

            [NameInMap("IsLineLessTable")]
            [Validation(Required=false)]
            public bool? IsLineLessTable { get; set; }

            [NameInMap("OutputTableExcel")]
            [Validation(Required=false)]
            public bool? OutputTableExcel { get; set; }

            [NameInMap("OutputTableHtml")]
            [Validation(Required=false)]
            public bool? OutputTableHtml { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Advanced</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.png">https://example.png</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}

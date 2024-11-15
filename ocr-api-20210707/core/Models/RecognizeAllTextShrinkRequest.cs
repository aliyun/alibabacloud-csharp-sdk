// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeAllTextShrinkRequest : TeaModel {
        [NameInMap("AdvancedConfig")]
        [Validation(Required=false)]
        public string AdvancedConfigShrink { get; set; }

        [NameInMap("IdCardConfig")]
        [Validation(Required=false)]
        public string IdCardConfigShrink { get; set; }

        [NameInMap("InternationalBusinessLicenseConfig")]
        [Validation(Required=false)]
        public string InternationalBusinessLicenseConfigShrink { get; set; }

        [NameInMap("InternationalIdCardConfig")]
        [Validation(Required=false)]
        public string InternationalIdCardConfigShrink { get; set; }

        [NameInMap("MultiLanConfig")]
        [Validation(Required=false)]
        public string MultiLanConfigShrink { get; set; }

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
        public string TableConfigShrink { get; set; }

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

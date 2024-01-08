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

        [NameInMap("OutputBarCode")]
        [Validation(Required=false)]
        public bool? OutputBarCode { get; set; }

        [NameInMap("OutputCoordinate")]
        [Validation(Required=false)]
        public byte[] OutputCoordinate { get; set; }

        [NameInMap("OutputFigure")]
        [Validation(Required=false)]
        public bool? OutputFigure { get; set; }

        [NameInMap("OutputKVExcel")]
        [Validation(Required=false)]
        public bool? OutputKVExcel { get; set; }

        [NameInMap("OutputOricoord")]
        [Validation(Required=false)]
        public bool? OutputOricoord { get; set; }

        [NameInMap("OutputQrcode")]
        [Validation(Required=false)]
        public bool? OutputQrcode { get; set; }

        [NameInMap("OutputStamp")]
        [Validation(Required=false)]
        public bool? OutputStamp { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("TableConfig")]
        [Validation(Required=false)]
        public string TableConfigShrink { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public Stream Body { get; set; }

    }

}

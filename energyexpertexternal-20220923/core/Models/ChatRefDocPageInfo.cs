// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatRefDocPageInfo : TeaModel {
        [NameInMap("angle")]
        [Validation(Required=false)]
        public double? Angle { get; set; }

        [NameInMap("excelParseResult")]
        [Validation(Required=false)]
        public string ExcelParseResult { get; set; }

        [NameInMap("imageHeight")]
        [Validation(Required=false)]
        public int? ImageHeight { get; set; }

        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("imageWidth")]
        [Validation(Required=false)]
        public int? ImageWidth { get; set; }

        [NameInMap("pageIdCurDoc")]
        [Validation(Required=false)]
        public int? PageIdCurDoc { get; set; }

        [NameInMap("pdfParseResult")]
        [Validation(Required=false)]
        public string PdfParseResult { get; set; }

        [NameInMap("wordParseResult")]
        [Validation(Required=false)]
        public string WordParseResult { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220729.Models
{
    public class SubmitTradeDocumentPackageExtractJobShrinkRequest : TeaModel {
        [NameInMap("CustomExtractionRange")]
        [Validation(Required=false)]
        public string CustomExtractionRangeShrink { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileNameExtension")]
        [Validation(Required=false)]
        public string FileNameExtension { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

    }

}

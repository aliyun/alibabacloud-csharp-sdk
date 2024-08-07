// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitDocStructureJobAdvanceRequest : TeaModel {
        [NameInMap("AllowPptFormat")]
        [Validation(Required=false)]
        public bool? AllowPptFormat { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileNameExtension")]
        [Validation(Required=false)]
        public string FileNameExtension { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        [NameInMap("FormulaEnhancement")]
        [Validation(Required=false)]
        public bool? FormulaEnhancement { get; set; }

        [NameInMap("StructureType")]
        [Validation(Required=false)]
        public string StructureType { get; set; }

    }

}

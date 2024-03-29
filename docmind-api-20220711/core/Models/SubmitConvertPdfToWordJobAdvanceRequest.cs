// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitConvertPdfToWordJobAdvanceRequest : TeaModel {
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        [NameInMap("ForceExportInnerImage")]
        [Validation(Required=false)]
        public bool? ForceExportInnerImage { get; set; }

    }

}

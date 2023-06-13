// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitDocStructureJobRequest : TeaModel {
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileNameExtension")]
        [Validation(Required=false)]
        public string FileNameExtension { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("StructureType")]
        [Validation(Required=false)]
        public string StructureType { get; set; }

    }

}

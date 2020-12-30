// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iqa20190813.Models
{
    public class UploadDictionaryRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("DictionaryFileUrl")]
        [Validation(Required=false)]
        public string DictionaryFileUrl { get; set; }

        [NameInMap("DictionaryData")]
        [Validation(Required=false)]
        public string DictionaryData { get; set; }

    }

}

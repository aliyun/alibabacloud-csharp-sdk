// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class CreateImageAnalyzeTaskRequest : TeaModel {
        [NameInMap("document")]
        [Validation(Required=false)]
        public CreateImageAnalyzeTaskRequestDocument Document { get; set; }
        public class CreateImageAnalyzeTaskRequestDocument : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("file_name")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("file_type")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}

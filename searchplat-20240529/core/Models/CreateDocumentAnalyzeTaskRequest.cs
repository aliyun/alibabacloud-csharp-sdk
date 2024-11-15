// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class CreateDocumentAnalyzeTaskRequest : TeaModel {
        [NameInMap("document")]
        [Validation(Required=false)]
        public CreateDocumentAnalyzeTaskRequestDocument Document { get; set; }
        public class CreateDocumentAnalyzeTaskRequestDocument : TeaModel {
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

        [NameInMap("output")]
        [Validation(Required=false)]
        public CreateDocumentAnalyzeTaskRequestOutput Output { get; set; }
        public class CreateDocumentAnalyzeTaskRequestOutput : TeaModel {
            [NameInMap("image_storage")]
            [Validation(Required=false)]
            public string ImageStorage { get; set; }

        }

    }

}

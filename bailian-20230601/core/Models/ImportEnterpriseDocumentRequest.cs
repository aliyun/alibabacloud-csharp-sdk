// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class ImportEnterpriseDocumentRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("DocumentList")]
        [Validation(Required=false)]
        public List<ImportEnterpriseDocumentRequestDocumentList> DocumentList { get; set; }
        public class ImportEnterpriseDocumentRequestDocumentList : TeaModel {
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("FileCanDownload")]
            [Validation(Required=false)]
            public bool? FileCanDownload { get; set; }

            [NameInMap("FileLink")]
            [Validation(Required=false)]
            public string FileLink { get; set; }

            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("FilePreviewLink")]
            [Validation(Required=false)]
            public string FilePreviewLink { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public long? StoreId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}

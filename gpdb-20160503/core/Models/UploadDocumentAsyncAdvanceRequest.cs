// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class UploadDocumentAsyncAdvanceRequest : TeaModel {
        [NameInMap("ChunkOverlap")]
        [Validation(Required=false)]
        public int? ChunkOverlap { get; set; }

        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DocumentLoaderName")]
        [Validation(Required=false)]
        public string DocumentLoaderName { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public Stream FileUrlObject { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NamespacePassword")]
        [Validation(Required=false)]
        public string NamespacePassword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Separators")]
        [Validation(Required=false)]
        public List<string> Separators { get; set; }

        [NameInMap("TextSplitterName")]
        [Validation(Required=false)]
        public string TextSplitterName { get; set; }

        [NameInMap("ZhTitleEnhance")]
        [Validation(Required=false)]
        public bool? ZhTitleEnhance { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaKnowledgeBaseDocument : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DocsCount")]
        [Validation(Required=false)]
        public int? DocsCount { get; set; }

        [NameInMap("DocumentLoaderName")]
        [Validation(Required=false)]
        public string DocumentLoaderName { get; set; }

        [NameInMap("FileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("KbUuid")]
        [Validation(Required=false)]
        public string KbUuid { get; set; }

        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("TextSplitterName")]
        [Validation(Required=false)]
        public string TextSplitterName { get; set; }

    }

}

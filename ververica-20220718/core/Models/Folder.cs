// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Folder : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public long? ModifiedAt { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        [NameInMap("subFolder")]
        [Validation(Required=false)]
        public List<SubFolder> SubFolder { get; set; }

        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateFolderResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Folder")]
        [Validation(Required=false)]
        public UpdateFolderResponseBodyFolder Folder { get; set; }
        public class UpdateFolderResponseBodyFolder : TeaModel {
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ParentFolderId")]
            [Validation(Required=false)]
            public string ParentFolderId { get; set; }
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }
        };

    }

}

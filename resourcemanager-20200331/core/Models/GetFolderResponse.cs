// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetFolderResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Folder")]
        [Validation(Required=true)]
        public GetFolderResponseFolder Folder { get; set; }
        public class GetFolderResponseFolder : TeaModel {
            [NameInMap("FolderId")]
            [Validation(Required=true)]
            public string FolderId { get; set; }
            [NameInMap("FolderName")]
            [Validation(Required=true)]
            public string FolderName { get; set; }
            [NameInMap("ParentFolderId")]
            [Validation(Required=true)]
            public string ParentFolderId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }
        };

    }

}

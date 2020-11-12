// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAncestorsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Folders")]
        [Validation(Required=true)]
        public ListAncestorsResponseFolders Folders { get; set; }
        public class ListAncestorsResponseFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=true)]
            public List<ListAncestorsResponseFoldersFolder> Folder { get; set; }
            public class ListAncestorsResponseFoldersFolder : TeaModel {
                public string FolderId { get; set; }
                public string FolderName { get; set; }
                public string CreateTime { get; set; }
            }
        };

    }

}

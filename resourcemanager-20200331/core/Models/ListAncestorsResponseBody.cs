// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAncestorsResponseBody : TeaModel {
        [NameInMap("Folders")]
        [Validation(Required=false)]
        public ListAncestorsResponseBodyFolders Folders { get; set; }
        public class ListAncestorsResponseBodyFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public List<ListAncestorsResponseBodyFoldersFolder> Folder { get; set; }
            public class ListAncestorsResponseBodyFoldersFolder : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                [NameInMap("FolderName")]
                [Validation(Required=false)]
                public string FolderName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

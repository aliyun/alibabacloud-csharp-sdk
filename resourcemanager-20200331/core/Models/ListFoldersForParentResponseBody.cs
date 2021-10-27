// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListFoldersForParentResponseBody : TeaModel {
        [NameInMap("Folders")]
        [Validation(Required=false)]
        public ListFoldersForParentResponseBodyFolders Folders { get; set; }
        public class ListFoldersForParentResponseBodyFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public List<ListFoldersForParentResponseBodyFoldersFolder> Folder { get; set; }
            public class ListFoldersForParentResponseBodyFoldersFolder : TeaModel {
                public string CreateTime { get; set; }
                public string FolderId { get; set; }
                public string FolderName { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

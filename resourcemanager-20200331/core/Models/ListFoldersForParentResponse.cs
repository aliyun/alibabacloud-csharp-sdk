// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListFoldersForParentResponse : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("Folders")]
        [Validation(Required=true)]
        public ListFoldersForParentResponseFolders Folders { get; set; }
        public class ListFoldersForParentResponseFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=true)]
            public List<ListFoldersForParentResponseFoldersFolder> Folder { get; set; }
            public class ListFoldersForParentResponseFoldersFolder : TeaModel {
                public string CreateTime { get; set; }
                public string FolderId { get; set; }
                public string FolderName { get; set; }
            }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListFoldersForParentResponseBody : TeaModel {
        /// <summary>
        /// The information of the folders.
        /// </summary>
        [NameInMap("Folders")]
        [Validation(Required=false)]
        public ListFoldersForParentResponseBodyFolders Folders { get; set; }
        public class ListFoldersForParentResponseBodyFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public List<ListFoldersForParentResponseBodyFoldersFolder> Folder { get; set; }
            public class ListFoldersForParentResponseBodyFoldersFolder : TeaModel {
                /// <summary>
                /// The time when the folder was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The ID of the folder.
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// The name of the folder.
                /// </summary>
                [NameInMap("FolderName")]
                [Validation(Required=false)]
                public string FolderName { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

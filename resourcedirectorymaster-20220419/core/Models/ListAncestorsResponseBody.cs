// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListAncestorsResponseBody : TeaModel {
        /// <summary>
        /// The information of the folders.
        /// </summary>
        [NameInMap("Folders")]
        [Validation(Required=false)]
        public ListAncestorsResponseBodyFolders Folders { get; set; }
        public class ListAncestorsResponseBodyFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public List<ListAncestorsResponseBodyFoldersFolder> Folder { get; set; }
            public class ListAncestorsResponseBodyFoldersFolder : TeaModel {
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateFolderResponseBody : TeaModel {
        /// <summary>
        /// The information of the folder.
        /// </summary>
        [NameInMap("Folder")]
        [Validation(Required=false)]
        public CreateFolderResponseBodyFolder Folder { get; set; }
        public class CreateFolderResponseBodyFolder : TeaModel {
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

            /// <summary>
            /// The ID of the parent folder.
            /// </summary>
            [NameInMap("ParentFolderId")]
            [Validation(Required=false)]
            public string ParentFolderId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

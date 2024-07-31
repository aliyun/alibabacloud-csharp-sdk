// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceFolderResponseBody : TeaModel {
        /// <summary>
        /// The details of the folder.
        /// </summary>
        [NameInMap("Folder")]
        [Validation(Required=false)]
        public GetDataServiceFolderResponseBodyFolder Folder { get; set; }
        public class GetDataServiceFolderResponseBodyFolder : TeaModel {
            /// <summary>
            /// The time when the folder was created.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The folder ID.
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public long? FolderId { get; set; }

            /// <summary>
            /// The name of the folder.
            /// </summary>
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }

            /// <summary>
            /// The ID of the business process to which the folder belongs.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The time when the folder was last modified.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// The parent folder ID. The ID of the root folder in a business process is 0, and the ID of a folder created by a user in a business process is greater than 0.
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// The workspace ID.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The tenant ID.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

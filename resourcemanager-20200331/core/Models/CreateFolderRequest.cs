// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreateFolderRequest : TeaModel {
        /// <summary>
        /// The name of the folder.
        /// 
        /// The name must be 1 to 24 characters in length and can contain letters, digits, underscores (\_), periods (.),and hyphens (-).
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

}

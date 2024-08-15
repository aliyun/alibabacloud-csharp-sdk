// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class UpdateFolderRequest : TeaModel {
        /// <summary>
        /// The ID of the folder.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// The new name of the folder.
        /// 
        /// The name must be 1 to 24 characters in length and can contain letters, digits, underscores (_), periods (.), and hyphens (-).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewFolderName")]
        [Validation(Required=false)]
        public string NewFolderName { get; set; }

    }

}

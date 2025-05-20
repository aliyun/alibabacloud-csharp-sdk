// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatFolderItem : TeaModel {
        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("folderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        [NameInMap("subFolders")]
        [Validation(Required=false)]
        public List<ChatItem> SubFolders { get; set; }

    }

}

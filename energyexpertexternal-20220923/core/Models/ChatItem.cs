// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatItem : TeaModel {
        [NameInMap("answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("folderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        [NameInMap("refDocList")]
        [Validation(Required=false)]
        public List<ChatRefDocItem> RefDocList { get; set; }

    }

}

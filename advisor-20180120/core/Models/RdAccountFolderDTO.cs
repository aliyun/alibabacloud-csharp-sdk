// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class RdAccountFolderDTO : TeaModel {
        [NameInMap("AccountCount")]
        [Validation(Required=false)]
        public int? AccountCount { get; set; }

        [NameInMap("AccountList")]
        [Validation(Required=false)]
        public List<RdAccountDTO> AccountList { get; set; }

        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("FolderList")]
        [Validation(Required=false)]
        public List<RdAccountFolderDTO> FolderList { get; set; }

        [NameInMap("FolderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        [NameInMap("ResourceDirectoryId")]
        [Validation(Required=false)]
        public string ResourceDirectoryId { get; set; }

        [NameInMap("ResourceDirectoryPath")]
        [Validation(Required=false)]
        public string ResourceDirectoryPath { get; set; }

        [NameInMap("ResourceDirectoryPathName")]
        [Validation(Required=false)]
        public string ResourceDirectoryPathName { get; set; }

        [NameInMap("SelectedCount")]
        [Validation(Required=false)]
        public int? SelectedCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class FolderItem : TeaModel {
        [NameInMap("currentLevel")]
        [Validation(Required=false)]
        public int? CurrentLevel { get; set; }

        [NameInMap("docCount")]
        [Validation(Required=false)]
        public int? DocCount { get; set; }

        [NameInMap("folderDefault")]
        [Validation(Required=false)]
        public int? FolderDefault { get; set; }

        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("folderName")]
        [Validation(Required=false)]
        public string FolderName { get; set; }

        [NameInMap("folderNum")]
        [Validation(Required=false)]
        public int? FolderNum { get; set; }

        [NameInMap("ossDomain")]
        [Validation(Required=false)]
        public string OssDomain { get; set; }

        [NameInMap("ossPath")]
        [Validation(Required=false)]
        public string OssPath { get; set; }

        [NameInMap("ossUpdateBy")]
        [Validation(Required=false)]
        public string OssUpdateBy { get; set; }

        [NameInMap("parentFolderId")]
        [Validation(Required=false)]
        public string ParentFolderId { get; set; }

        [NameInMap("resourcePath")]
        [Validation(Required=false)]
        public string ResourcePath { get; set; }

        [NameInMap("storageType")]
        [Validation(Required=false)]
        public int? StorageType { get; set; }

        [NameInMap("subFolderList")]
        [Validation(Required=false)]
        public List<FolderItem> SubFolderList { get; set; }

        [NameInMap("syncParsingStatus")]
        [Validation(Required=false)]
        public int? SyncParsingStatus { get; set; }

        [NameInMap("syncStatus")]
        [Validation(Required=false)]
        public int? SyncStatus { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}

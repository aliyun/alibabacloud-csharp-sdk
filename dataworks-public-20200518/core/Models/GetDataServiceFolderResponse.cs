// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceFolderResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Folder")]
        [Validation(Required=true)]
        public GetDataServiceFolderResponseFolder Folder { get; set; }
        public class GetDataServiceFolderResponseFolder : TeaModel {
            [NameInMap("TenantId")]
            [Validation(Required=true)]
            public long TenantId { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=true)]
            public long ProjectId { get; set; }
            [NameInMap("FolderId")]
            [Validation(Required=true)]
            public long FolderId { get; set; }
            [NameInMap("FolderName")]
            [Validation(Required=true)]
            public string FolderName { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=true)]
            public string CreatedTime { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=true)]
            public string ModifiedTime { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=true)]
            public string GroupId { get; set; }
            [NameInMap("ParentId")]
            [Validation(Required=true)]
            public long ParentId { get; set; }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceFolderResponseBody : TeaModel {
        [NameInMap("Folder")]
        [Validation(Required=false)]
        public GetDataServiceFolderResponseBodyFolder Folder { get; set; }
        public class GetDataServiceFolderResponseBodyFolder : TeaModel {
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public long? FolderId { get; set; }
            [NameInMap("FolderName")]
            [Validation(Required=false)]
            public string FolderName { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

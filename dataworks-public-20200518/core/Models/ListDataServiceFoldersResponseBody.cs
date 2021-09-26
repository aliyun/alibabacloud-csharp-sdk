// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceFoldersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FolderPagingResult")]
        [Validation(Required=false)]
        public ListDataServiceFoldersResponseBodyFolderPagingResult FolderPagingResult { get; set; }
        public class ListDataServiceFoldersResponseBodyFolderPagingResult : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Folders")]
            [Validation(Required=false)]
            public List<ListDataServiceFoldersResponseBodyFolderPagingResultFolders> Folders { get; set; }
            public class ListDataServiceFoldersResponseBodyFolderPagingResultFolders : TeaModel {
                public long? ParentId { get; set; }
                public string ModifiedTime { get; set; }
                public string GroupId { get; set; }
                public long? FolderId { get; set; }
                public string FolderName { get; set; }
                public long? ProjectId { get; set; }
                public string CreatedTime { get; set; }
                public long? TenantId { get; set; }
            }
        };

    }

}

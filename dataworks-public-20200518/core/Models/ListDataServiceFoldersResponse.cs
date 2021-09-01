// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceFoldersResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("FolderPagingResult")]
        [Validation(Required=true)]
        public ListDataServiceFoldersResponseFolderPagingResult FolderPagingResult { get; set; }
        public class ListDataServiceFoldersResponseFolderPagingResult : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("Folders")]
            [Validation(Required=true)]
            public List<ListDataServiceFoldersResponseFolderPagingResultFolders> Folders { get; set; }
            public class ListDataServiceFoldersResponseFolderPagingResultFolders : TeaModel {
                public long? FolderId { get; set; }
                public string FolderName { get; set; }
                public long? ProjectId { get; set; }
                public long? TenantId { get; set; }
                public string CreatedTime { get; set; }
                public string ModifiedTime { get; set; }
                public string GroupId { get; set; }
                public long? ParentId { get; set; }
            }
        };

    }

}

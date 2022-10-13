// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDataServiceFoldersResponseBody : TeaModel {
        [NameInMap("FolderPagingResult")]
        [Validation(Required=false)]
        public ListDataServiceFoldersResponseBodyFolderPagingResult FolderPagingResult { get; set; }
        public class ListDataServiceFoldersResponseBodyFolderPagingResult : TeaModel {
            [NameInMap("Folders")]
            [Validation(Required=false)]
            public List<ListDataServiceFoldersResponseBodyFolderPagingResultFolders> Folders { get; set; }
            public class ListDataServiceFoldersResponseBodyFolderPagingResultFolders : TeaModel {
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

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListFunctionFilesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FileList")]
        [Validation(Required=false)]
        public ListFunctionFilesResponseBodyFileList FileList { get; set; }
        public class ListFunctionFilesResponseBodyFileList : TeaModel {
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<ListFunctionFilesResponseBodyFileListFiles> Files { get; set; }
            public class ListFunctionFilesResponseBodyFileListFiles : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
                public long? ContentId { get; set; }
                public int? Status { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string Description { get; set; }
                public long? SandboxDeployTime { get; set; }
                public long? ProductionDeployTime { get; set; }
                public int? SandboxDeployStatus { get; set; }
                public int? ProductionDeployStatus { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListFunctionFilesResponseBodyFileListPagination Pagination { get; set; }
            public class ListFunctionFilesResponseBodyFileListPagination : TeaModel {
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public int? TotalPageCount { get; set; }

            }
        };

    }

}

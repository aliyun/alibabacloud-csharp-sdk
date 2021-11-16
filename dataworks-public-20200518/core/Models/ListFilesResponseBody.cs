// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFilesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFilesResponseBodyData Data { get; set; }
        public class ListFilesResponseBodyData : TeaModel {
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<ListFilesResponseBodyDataFiles> Files { get; set; }
            public class ListFilesResponseBodyDataFiles : TeaModel {
                public bool? AutoParsing { get; set; }
                public long? BizId { get; set; }
                public long? BusinessId { get; set; }
                public int? CommitStatus { get; set; }
                public string ConnectionName { get; set; }
                public string Content { get; set; }
                public long? CreateTime { get; set; }
                public string CreateUser { get; set; }
                public int? CurrentVersion { get; set; }
                public string FileDescription { get; set; }
                public string FileFolderId { get; set; }
                public long? FileId { get; set; }
                public string FileName { get; set; }
                public int? FileType { get; set; }
                public bool? IsMaxCompute { get; set; }
                public long? LastEditTime { get; set; }
                public string LastEditUser { get; set; }
                public long? NodeId { get; set; }
                public string Owner { get; set; }
                public long? ParentId { get; set; }
                public string UseType { get; set; }
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
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

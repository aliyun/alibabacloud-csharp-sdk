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
                [NameInMap("AutoParsing")]
                [Validation(Required=false)]
                public bool? AutoParsing { get; set; }

                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                [NameInMap("CommitStatus")]
                [Validation(Required=false)]
                public int? CommitStatus { get; set; }

                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public int? CurrentVersion { get; set; }

                [NameInMap("FileDescription")]
                [Validation(Required=false)]
                public string FileDescription { get; set; }

                [NameInMap("FileFolderId")]
                [Validation(Required=false)]
                public string FileFolderId { get; set; }

                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                [NameInMap("IsMaxCompute")]
                [Validation(Required=false)]
                public bool? IsMaxCompute { get; set; }

                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                [NameInMap("LastEditUser")]
                [Validation(Required=false)]
                public string LastEditUser { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("UseType")]
                [Validation(Required=false)]
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

        }

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

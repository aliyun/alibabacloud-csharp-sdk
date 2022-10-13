// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFileVersionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFileVersionsResponseBodyData Data { get; set; }
        public class ListFileVersionsResponseBodyData : TeaModel {
            [NameInMap("FileVersions")]
            [Validation(Required=false)]
            public List<ListFileVersionsResponseBodyDataFileVersions> FileVersions { get; set; }
            public class ListFileVersionsResponseBodyDataFileVersions : TeaModel {
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("CommitTime")]
                [Validation(Required=false)]
                public long? CommitTime { get; set; }

                [NameInMap("CommitUser")]
                [Validation(Required=false)]
                public string CommitUser { get; set; }

                [NameInMap("FileContent")]
                [Validation(Required=false)]
                public string FileContent { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FilePropertyContent")]
                [Validation(Required=false)]
                public string FilePropertyContent { get; set; }

                [NameInMap("FileVersion")]
                [Validation(Required=false)]
                public int? FileVersion { get; set; }

                [NameInMap("IsCurrentProd")]
                [Validation(Required=false)]
                public bool? IsCurrentProd { get; set; }

                [NameInMap("NodeContent")]
                [Validation(Required=false)]
                public string NodeContent { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFileVersionsResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFileVersionsResponseBodyData Data { get; set; }
        public class ListFileVersionsResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("FileVersions")]
            [Validation(Required=false)]
            public List<ListFileVersionsResponseBodyDataFileVersions> FileVersions { get; set; }
            public class ListFileVersionsResponseBodyDataFileVersions : TeaModel {
                public string FileContent { get; set; }
                public string Status { get; set; }
                public bool? IsCurrentProd { get; set; }
                public string CommitUser { get; set; }
                public string NodeContent { get; set; }
                public string Comment { get; set; }
                public string FilePropertyContent { get; set; }
                public string FileName { get; set; }
                public string UseType { get; set; }
                public string ChangeType { get; set; }
                public int? FileVersion { get; set; }
                public long? CommitTime { get; set; }
                public long? NodeId { get; set; }
            }
        };

    }

}

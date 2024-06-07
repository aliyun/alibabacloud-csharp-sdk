// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListTablePartitionsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTablePartitionsResponseBodyData Data { get; set; }
        public class ListTablePartitionsResponseBodyData : TeaModel {
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("PagedData")]
            [Validation(Required=false)]
            public List<ListTablePartitionsResponseBodyDataPagedData> PagedData { get; set; }
            public class ListTablePartitionsResponseBodyDataPagedData : TeaModel {
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("PartitionComment")]
                [Validation(Required=false)]
                public string PartitionComment { get; set; }

                [NameInMap("PartitionName")]
                [Validation(Required=false)]
                public string PartitionName { get; set; }

                [NameInMap("PartitionPath")]
                [Validation(Required=false)]
                public string PartitionPath { get; set; }

                [NameInMap("PartitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

            }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

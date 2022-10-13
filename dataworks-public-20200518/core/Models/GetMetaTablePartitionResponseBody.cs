// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTablePartitionResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTablePartitionResponseBodyData Data { get; set; }
        public class GetMetaTablePartitionResponseBodyData : TeaModel {
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<GetMetaTablePartitionResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTablePartitionResponseBodyDataDataEntityList : TeaModel {
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                [NameInMap("PartitionGuid")]
                [Validation(Required=false)]
                public string PartitionGuid { get; set; }

                [NameInMap("PartitionLocation")]
                [Validation(Required=false)]
                public string PartitionLocation { get; set; }

                [NameInMap("PartitionName")]
                [Validation(Required=false)]
                public string PartitionName { get; set; }

                [NameInMap("PartitionPath")]
                [Validation(Required=false)]
                public string PartitionPath { get; set; }

                [NameInMap("PartitionType")]
                [Validation(Required=false)]
                public string PartitionType { get; set; }

                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public long? RecordCount { get; set; }

                [NameInMap("TableGuid")]
                [Validation(Required=false)]
                public string TableGuid { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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

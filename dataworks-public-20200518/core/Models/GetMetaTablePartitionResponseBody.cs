// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTablePartitionResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTablePartitionResponseBodyData Data { get; set; }
        public class GetMetaTablePartitionResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<GetMetaTablePartitionResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTablePartitionResponseBodyDataDataEntityList : TeaModel {
                public string PartitionPath { get; set; }
                public long? DataSize { get; set; }
                public string PartitionName { get; set; }
                public string Comment { get; set; }
                public long? ModifiedTime { get; set; }
                public long? CreateTime { get; set; }
                public long? RecordCount { get; set; }
                public string PartitionType { get; set; }
                public string PartitionGuid { get; set; }
                public string PartitionLocation { get; set; }
                public string TableGuid { get; set; }
            }
        };

    }

}

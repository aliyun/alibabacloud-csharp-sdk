// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableChangeLogResponseBody : TeaModel {
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
        public GetMetaTableChangeLogResponseBodyData Data { get; set; }
        public class GetMetaTableChangeLogResponseBodyData : TeaModel {
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
            public List<GetMetaTableChangeLogResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaTableChangeLogResponseBodyDataDataEntityList : TeaModel {
                public string ObjectType { get; set; }
                public long? ModifiedTime { get; set; }
                public long? CreateTime { get; set; }
                public string ChangeContent { get; set; }
                public string Operator { get; set; }
                public string ChangeType { get; set; }
            }
        };

    }

}

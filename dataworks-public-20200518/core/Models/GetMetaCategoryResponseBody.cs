// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaCategoryResponseBody : TeaModel {
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
        public GetMetaCategoryResponseBodyData Data { get; set; }
        public class GetMetaCategoryResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<GetMetaCategoryResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class GetMetaCategoryResponseBodyDataDataEntityList : TeaModel {
                public int? Depth { get; set; }
                public string Comment { get; set; }
                public long? ModifiedTime { get; set; }
                public long? CreateTime { get; set; }
                public long? CategoryId { get; set; }
                public string LastOperatorId { get; set; }
                public string Name { get; set; }
                public long? ParentCategoryId { get; set; }
                public string OwnerId { get; set; }
            }
        };

    }

}

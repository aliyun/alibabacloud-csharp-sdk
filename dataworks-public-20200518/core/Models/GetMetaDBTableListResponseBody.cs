// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaDBTableListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaDBTableListResponseBodyData Data { get; set; }
        public class GetMetaDBTableListResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("TableEntityList")]
            [Validation(Required=false)]
            public List<GetMetaDBTableListResponseBodyDataTableEntityList> TableEntityList { get; set; }
            public class GetMetaDBTableListResponseBodyDataTableEntityList : TeaModel {
                public string TableName { get; set; }
                public string TableGuid { get; set; }
                public string DatabaseName { get; set; }
            }
        };

    }

}

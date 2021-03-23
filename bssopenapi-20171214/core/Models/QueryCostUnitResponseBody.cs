// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCostUnitResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCostUnitResponseBodyData Data { get; set; }
        public class QueryCostUnitResponseBodyData : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("CostUnitDtoList")]
            [Validation(Required=false)]
            public List<QueryCostUnitResponseBodyDataCostUnitDtoList> CostUnitDtoList { get; set; }
            public class QueryCostUnitResponseBodyDataCostUnitDtoList : TeaModel {
                public long? UnitId { get; set; }
                public long? ParentUnitId { get; set; }
                public long? OwnerUid { get; set; }
                public string UnitName { get; set; }
            }
        };

    }

}

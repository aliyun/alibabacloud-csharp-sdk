// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCostUnitResourceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCostUnitResourceResponseBodyData Data { get; set; }
        public class QueryCostUnitResourceResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("ResourceInstanceDtoList")]
            [Validation(Required=false)]
            public List<QueryCostUnitResourceResponseBodyDataResourceInstanceDtoList> ResourceInstanceDtoList { get; set; }
            public class QueryCostUnitResourceResponseBodyDataResourceInstanceDtoList : TeaModel {
                public string CommodityCode { get; set; }
                public string ResourceUserName { get; set; }
                public string CommodityName { get; set; }
                public long? ResourceUserId { get; set; }
                public string ApportionName { get; set; }
                public string ApportionCode { get; set; }
                public string ResourceType { get; set; }
                public string ResourceNick { get; set; }
                public string ResourceTag { get; set; }
                public string ResourceId { get; set; }
                public string ResourceGroup { get; set; }
                public string RelatedResources { get; set; }
                public string ResourceStatus { get; set; }
            }
            [NameInMap("CostUnit")]
            [Validation(Required=false)]
            public QueryCostUnitResourceResponseBodyDataCostUnit CostUnit { get; set; }
            public class QueryCostUnitResourceResponseBodyDataCostUnit : TeaModel {
                [NameInMap("ParentUnitId")]
                [Validation(Required=false)]
                public long? ParentUnitId { get; set; }

                [NameInMap("UnitName")]
                [Validation(Required=false)]
                public string UnitName { get; set; }

                [NameInMap("UnitId")]
                [Validation(Required=false)]
                public long? UnitId { get; set; }

                [NameInMap("OwnerUid")]
                [Validation(Required=false)]
                public long? OwnerUid { get; set; }

            }
            [NameInMap("CostUnitStatisInfo")]
            [Validation(Required=false)]
            public QueryCostUnitResourceResponseBodyDataCostUnitStatisInfo CostUnitStatisInfo { get; set; }
            public class QueryCostUnitResourceResponseBodyDataCostUnitStatisInfo : TeaModel {
                [NameInMap("TotalResourceCount")]
                [Validation(Required=false)]
                public long? TotalResourceCount { get; set; }

                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public long? ResourceCount { get; set; }

                [NameInMap("TotalUserCount")]
                [Validation(Required=false)]
                public long? TotalUserCount { get; set; }

                [NameInMap("SubUnitCount")]
                [Validation(Required=false)]
                public long? SubUnitCount { get; set; }

                [NameInMap("ResourceGroupCount")]
                [Validation(Required=false)]
                public long? ResourceGroupCount { get; set; }

                [NameInMap("TotalResourceGroupCount")]
                [Validation(Required=false)]
                public long? TotalResourceGroupCount { get; set; }

                [NameInMap("UserCount")]
                [Validation(Required=false)]
                public long? UserCount { get; set; }

            }
        };

    }

}

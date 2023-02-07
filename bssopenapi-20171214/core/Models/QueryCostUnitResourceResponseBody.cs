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

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCostUnitResourceResponseBodyData Data { get; set; }
        public class QueryCostUnitResourceResponseBodyData : TeaModel {
            [NameInMap("CostUnit")]
            [Validation(Required=false)]
            public QueryCostUnitResourceResponseBodyDataCostUnit CostUnit { get; set; }
            public class QueryCostUnitResourceResponseBodyDataCostUnit : TeaModel {
                [NameInMap("OwnerUid")]
                [Validation(Required=false)]
                public long? OwnerUid { get; set; }

                [NameInMap("ParentUnitId")]
                [Validation(Required=false)]
                public long? ParentUnitId { get; set; }

                [NameInMap("UnitId")]
                [Validation(Required=false)]
                public long? UnitId { get; set; }

                [NameInMap("UnitName")]
                [Validation(Required=false)]
                public string UnitName { get; set; }

            }

            [NameInMap("CostUnitStatisInfo")]
            [Validation(Required=false)]
            public QueryCostUnitResourceResponseBodyDataCostUnitStatisInfo CostUnitStatisInfo { get; set; }
            public class QueryCostUnitResourceResponseBodyDataCostUnitStatisInfo : TeaModel {
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public long? ResourceCount { get; set; }

                [NameInMap("ResourceGroupCount")]
                [Validation(Required=false)]
                public long? ResourceGroupCount { get; set; }

                [NameInMap("SubUnitCount")]
                [Validation(Required=false)]
                public long? SubUnitCount { get; set; }

                [NameInMap("TotalResourceCount")]
                [Validation(Required=false)]
                public long? TotalResourceCount { get; set; }

                [NameInMap("TotalResourceGroupCount")]
                [Validation(Required=false)]
                public long? TotalResourceGroupCount { get; set; }

                [NameInMap("TotalUserCount")]
                [Validation(Required=false)]
                public long? TotalUserCount { get; set; }

                [NameInMap("UserCount")]
                [Validation(Required=false)]
                public long? UserCount { get; set; }

            }

            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("ResourceInstanceDtoList")]
            [Validation(Required=false)]
            public List<QueryCostUnitResourceResponseBodyDataResourceInstanceDtoList> ResourceInstanceDtoList { get; set; }
            public class QueryCostUnitResourceResponseBodyDataResourceInstanceDtoList : TeaModel {
                [NameInMap("ApportionCode")]
                [Validation(Required=false)]
                public string ApportionCode { get; set; }

                [NameInMap("ApportionName")]
                [Validation(Required=false)]
                public string ApportionName { get; set; }

                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                [NameInMap("RelatedResources")]
                [Validation(Required=false)]
                public string RelatedResources { get; set; }

                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceNick")]
                [Validation(Required=false)]
                public string ResourceNick { get; set; }

                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                [NameInMap("ResourceTag")]
                [Validation(Required=false)]
                public string ResourceTag { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("ResourceUserId")]
                [Validation(Required=false)]
                public long? ResourceUserId { get; set; }

                [NameInMap("ResourceUserName")]
                [Validation(Required=false)]
                public string ResourceUserName { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

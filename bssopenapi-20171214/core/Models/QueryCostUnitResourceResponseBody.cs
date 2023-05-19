// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCostUnitResourceResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCostUnitResourceResponseBodyData Data { get; set; }
        public class QueryCostUnitResourceResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the cost center.
            /// </summary>
            [NameInMap("CostUnit")]
            [Validation(Required=false)]
            public QueryCostUnitResourceResponseBodyDataCostUnit CostUnit { get; set; }
            public class QueryCostUnitResourceResponseBodyDataCostUnit : TeaModel {
                /// <summary>
                /// The user ID of the cost center owner.
                /// </summary>
                [NameInMap("OwnerUid")]
                [Validation(Required=false)]
                public long? OwnerUid { get; set; }

                /// <summary>
                /// The ID of the parent cost center. A value of -1 indicates the root cost center.
                /// </summary>
                [NameInMap("ParentUnitId")]
                [Validation(Required=false)]
                public long? ParentUnitId { get; set; }

                /// <summary>
                /// The ID of the cost center.
                /// </summary>
                [NameInMap("UnitId")]
                [Validation(Required=false)]
                public long? UnitId { get; set; }

                /// <summary>
                /// The name of the cost center.
                /// </summary>
                [NameInMap("UnitName")]
                [Validation(Required=false)]
                public string UnitName { get; set; }

            }

            /// <summary>
            /// The statistical information about the cost center.
            /// </summary>
            [NameInMap("CostUnitStatisInfo")]
            [Validation(Required=false)]
            public QueryCostUnitResourceResponseBodyDataCostUnitStatisInfo CostUnitStatisInfo { get; set; }
            public class QueryCostUnitResourceResponseBodyDataCostUnitStatisInfo : TeaModel {
                /// <summary>
                /// The number of resource instances in the cost center.
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public long? ResourceCount { get; set; }

                /// <summary>
                /// The number of resource groups in the cost center.
                /// </summary>
                [NameInMap("ResourceGroupCount")]
                [Validation(Required=false)]
                public long? ResourceGroupCount { get; set; }

                /// <summary>
                /// The number of sub-cost centers in the cost center.
                /// </summary>
                [NameInMap("SubUnitCount")]
                [Validation(Required=false)]
                public long? SubUnitCount { get; set; }

                /// <summary>
                /// The total number of resource instances, including resource instances of sub-cost centers, in the cost center.
                /// </summary>
                [NameInMap("TotalResourceCount")]
                [Validation(Required=false)]
                public long? TotalResourceCount { get; set; }

                /// <summary>
                /// The total number of resource groups, including resource groups of sub-cost centers, in the cost center.
                /// </summary>
                [NameInMap("TotalResourceGroupCount")]
                [Validation(Required=false)]
                public long? TotalResourceGroupCount { get; set; }

                /// <summary>
                /// The total number of the associated accounts, including associated accounts of sub-cost centers, in the cost center.
                /// </summary>
                [NameInMap("TotalUserCount")]
                [Validation(Required=false)]
                public long? TotalUserCount { get; set; }

                /// <summary>
                /// The number of sub-cost centers in the cost center.
                /// </summary>
                [NameInMap("UserCount")]
                [Validation(Required=false)]
                public long? UserCount { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The resource instances.
            /// </summary>
            [NameInMap("ResourceInstanceDtoList")]
            [Validation(Required=false)]
            public List<QueryCostUnitResourceResponseBodyDataResourceInstanceDtoList> ResourceInstanceDtoList { get; set; }
            public class QueryCostUnitResourceResponseBodyDataResourceInstanceDtoList : TeaModel {
                /// <summary>
                /// The split code of the resource.
                /// </summary>
                [NameInMap("ApportionCode")]
                [Validation(Required=false)]
                public string ApportionCode { get; set; }

                /// <summary>
                /// The split name of the resource.
                /// </summary>
                [NameInMap("ApportionName")]
                [Validation(Required=false)]
                public string ApportionName { get; set; }

                /// <summary>
                /// The product code of the resource.
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The commodity name of the resource.
                /// </summary>
                [NameInMap("CommodityName")]
                [Validation(Required=false)]
                public string CommodityName { get; set; }

                /// <summary>
                /// The resources related to the resource instance.
                /// </summary>
                [NameInMap("RelatedResources")]
                [Validation(Required=false)]
                public string RelatedResources { get; set; }

                /// <summary>
                /// The resource group to which the resource belongs.
                /// </summary>
                [NameInMap("ResourceGroup")]
                [Validation(Required=false)]
                public string ResourceGroup { get; set; }

                /// <summary>
                /// The instance ID of the resource.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The custom name of the resource.
                /// </summary>
                [NameInMap("ResourceNick")]
                [Validation(Required=false)]
                public string ResourceNick { get; set; }

                /// <summary>
                /// The status of the resource.
                /// </summary>
                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                /// <summary>
                /// The tags of the resource.
                /// </summary>
                [NameInMap("ResourceTag")]
                [Validation(Required=false)]
                public string ResourceTag { get; set; }

                /// <summary>
                /// The type of the resource.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The user ID of the resource owner.
                /// </summary>
                [NameInMap("ResourceUserId")]
                [Validation(Required=false)]
                public long? ResourceUserId { get; set; }

                /// <summary>
                /// The username of the resource owner.
                /// </summary>
                [NameInMap("ResourceUserName")]
                [Validation(Required=false)]
                public string ResourceUserName { get; set; }

            }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

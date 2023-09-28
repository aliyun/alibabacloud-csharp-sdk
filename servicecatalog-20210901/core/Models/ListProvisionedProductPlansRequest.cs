// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductPlansRequest : TeaModel {
        /// <summary>
        /// The access filter. Valid values:
        /// 
        /// *   User (default): queries the plans that are created by the current requester.
        /// *   Account: queries the plans that belong to the current Alibaba Cloud account.
        /// *   ResourceDirectory: queries the plans that belong to the current resource directory.
        /// </summary>
        [NameInMap("AccessLevelFilter")]
        [Validation(Required=false)]
        public string AccessLevelFilter { get; set; }

        /// <summary>
        /// The access filter of the review dimension. Valid values:
        /// 
        /// *   ReceivedRequests: queries plans that are pending for review.
        /// *   ApprovalHistory: queries review history.
        /// *   AccountRequests: queries all plans that belong to the current Alibaba Cloud account.
        /// *   AccountRequests: queries all plans that belong to the current Alibaba Cloud account.
        /// </summary>
        [NameInMap("ApprovalFilter")]
        [Validation(Required=false)]
        public string ApprovalFilter { get; set; }

        /// <summary>
        /// An array that consists of filter conditions.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListProvisionedProductPlansRequestFilters> Filters { get; set; }
        public class ListProvisionedProductPlansRequestFilters : TeaModel {
            /// <summary>
            /// The name of the filter condition. Valid values:
            /// 
            /// *   ProvisionedProductPlanName: performs exact matches by plan name. Plan names are not case-sensitive.
            /// *   ProvisionedProductPlanApprover: performs exact matches by reviewer. You must specify a reviewer in the `RamUser/RamRole:<Name of the reviewer>` format. You can specify multiple reviewers.
            /// *   ProvisionedProductPlanApproverName: performs matches by reviewer name. You must specify the Resource Access Management (RAM) entity name of the reviewer. You can specify multiple reviewer names.
            /// *   ProvisionedProductPlanStatus: performs matches by plan status. You must specify the state of the plan. You can specify multiple states.
            /// *   ProvisionedProductPlanOwnerUid: performs exact matches by ID of Alibaba Cloud account to which a plan belongs.
            /// *   FullTextSearch: performs fuzzy full-text searches by plan name.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the filter condition.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100. Minimum value: 1. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the product instance.
        /// </summary>
        [NameInMap("ProvisionedProductId")]
        [Validation(Required=false)]
        public string ProvisionedProductId { get; set; }

        /// <summary>
        /// The information based on which you want to sort the query results.
        /// 
        /// Set the value to CreateTime, which specifies the creation time of plans.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The order in which you want to sort the query results. Valid values:
        /// 
        /// *   Asc: the ascending order
        /// *   Desc (default): the descending order.
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}

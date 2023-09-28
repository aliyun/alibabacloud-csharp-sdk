// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductPlanApproversRequest : TeaModel {
        /// <summary>
        /// The access filter. Valid values:
        /// 
        /// *   User (default): queries the plans that are created by the current requester.
        /// *   Account: queries the plans that belong to the current Alibaba Cloud account.
        /// *   ResourceDirectory: queries the plans that belong to the current resource directory.
        /// 
        /// >  You must specify one of the `ApprovalFilter` and `AccessLevelFilter` parameters, but not both.
        /// </summary>
        [NameInMap("AccessLevelFilter")]
        [Validation(Required=false)]
        public string AccessLevelFilter { get; set; }

        /// <summary>
        /// The access filter of the review dimension. Valid values:
        /// 
        /// *   AccountRequests: queries all reviewed plans that belong to the current Alibaba Cloud account.
        /// *   ResourceDirectoryRequests: queries all plans that belong to the current resource directory.
        /// 
        /// >  You must specify one of the `ApprovalFilter` and `AccessLevelFilter` parameters, but not both.
        /// </summary>
        [NameInMap("ApprovalFilter")]
        [Validation(Required=false)]
        public string ApprovalFilter { get; set; }

        /// <summary>
        /// An array that consists of filter conditions.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListProvisionedProductPlanApproversRequestFilters> Filters { get; set; }
        public class ListProvisionedProductPlanApproversRequestFilters : TeaModel {
            /// <summary>
            /// The name of the filter condition. Valid values:
            /// 
            /// *   ProvisionedProductPlanApproverName: performs fuzzy match by reviewer name.
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

    }

}

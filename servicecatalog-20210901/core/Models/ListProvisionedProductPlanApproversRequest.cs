// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductPlanApproversRequest : TeaModel {
        /// <summary>
        /// <para>The access filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User (default): queries the plans that are created by the current requester.</description></item>
        /// <item><description>Account: queries the plans that belong to the current Alibaba Cloud account.</description></item>
        /// <item><description>ResourceDirectory: queries the plans that belong to the current resource directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify one of the <c>ApprovalFilter</c> and <c>AccessLevelFilter</c> parameters, but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("AccessLevelFilter")]
        [Validation(Required=false)]
        public string AccessLevelFilter { get; set; }

        /// <summary>
        /// <para>The access filter of the review dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AccountRequests: queries all reviewed plans that belong to the current Alibaba Cloud account.</description></item>
        /// <item><description>ResourceDirectoryRequests: queries all plans that belong to the current resource directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify one of the <c>ApprovalFilter</c> and <c>AccessLevelFilter</c> parameters, but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AccountRequests</para>
        /// </summary>
        [NameInMap("ApprovalFilter")]
        [Validation(Required=false)]
        public string ApprovalFilter { get; set; }

        /// <summary>
        /// <para>An array that consists of filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListProvisionedProductPlanApproversRequestFilters> Filters { get; set; }
        public class ListProvisionedProductPlanApproversRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ProvisionedProductPlanApproverName: performs fuzzy match by reviewer name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ProvisionedProductPlanApproverName</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approver</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}

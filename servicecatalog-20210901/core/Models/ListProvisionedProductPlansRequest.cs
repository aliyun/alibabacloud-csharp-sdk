// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductPlansRequest : TeaModel {
        /// <summary>
        /// <para>The access filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User (default): queries the plans that are created by the current requester.</description></item>
        /// <item><description>Account: queries the plans that belong to the current Alibaba Cloud account.</description></item>
        /// <item><description>ResourceDirectory: queries the plans that belong to the current resource directory.</description></item>
        /// </list>
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
        /// <item><description>ReceivedRequests: queries plans that are pending for review.</description></item>
        /// <item><description>ApprovalHistory: queries review history.</description></item>
        /// <item><description>AccountRequests: queries all plans that belong to the current Alibaba Cloud account.</description></item>
        /// <item><description>AccountRequests: queries all plans that belong to the current Alibaba Cloud account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ReceivedRequests</para>
        /// </summary>
        [NameInMap("ApprovalFilter")]
        [Validation(Required=false)]
        public string ApprovalFilter { get; set; }

        /// <summary>
        /// <para>An array that consists of filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListProvisionedProductPlansRequestFilters> Filters { get; set; }
        public class ListProvisionedProductPlansRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ProvisionedProductPlanName: performs exact matches by plan name. Plan names are not case-sensitive.</description></item>
            /// <item><description>ProvisionedProductPlanApprover: performs exact matches by reviewer. You must specify a reviewer in the <c>RamUser/RamRole:&lt;Name of the reviewer&gt;</c> format. You can specify multiple reviewers.</description></item>
            /// <item><description>ProvisionedProductPlanApproverName: performs matches by reviewer name. You must specify the Resource Access Management (RAM) entity name of the reviewer. You can specify multiple reviewer names.</description></item>
            /// <item><description>ProvisionedProductPlanStatus: performs matches by plan status. You must specify the state of the plan. You can specify multiple states.</description></item>
            /// <item><description>ProvisionedProductPlanOwnerUid: performs exact matches by ID of Alibaba Cloud account to which a plan belongs.</description></item>
            /// <item><description>FullTextSearch: performs fuzzy full-text searches by plan name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FullTextSearch</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100. Minimum value: 1. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the product instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pp-bp1ddg1n2a****</para>
        /// </summary>
        [NameInMap("ProvisionedProductId")]
        [Validation(Required=false)]
        public string ProvisionedProductId { get; set; }

        /// <summary>
        /// <para>The information based on which you want to sort the query results.</para>
        /// <para>Set the value to CreateTime, which specifies the creation time of plans.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: the ascending order</description></item>
        /// <item><description>Desc (default): the descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeCostBudgetsSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The name of the budget. Supports fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>全年预算</para>
        /// </summary>
        [NameInMap("BudgetName")]
        [Validation(Required=false)]
        public string BudgetName { get; set; }

        /// <summary>
        /// <para>The status of the budget. If you do not specify this parameter, budgets in all statuses are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notOverdue</para>
        /// </summary>
        [NameInMap("BudgetStatus")]
        [Validation(Required=false)]
        public string BudgetStatus { get; set; }

        /// <summary>
        /// <para>The type of the budget. If you do not specify this parameter, budgets of all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cost</para>
        /// </summary>
        [NameInMap("BudgetType")]
        [Validation(Required=false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// <para>The maximum number of items to return. Valid values: 1 to 10. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Set this parameter to the NextToken value that is returned in the response to the previous request. If you do not specify this parameter, the query starts from the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6NH0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

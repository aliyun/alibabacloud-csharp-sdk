// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeCostBudgetsSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The name of the budget. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Annual budget</para>
        /// </summary>
        [NameInMap("BudgetName")]
        [Validation(Required=false)]
        public string BudgetName { get; set; }

        /// <summary>
        /// <para>The status of the budget. Valid values: overdue and notOverdue. A value of overdue specifies to filter expired budgets. A value of notOverdue specifies to filter budgets that do not expire. By default, if you do not specify this parameter, information about all budgets is to be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notOverdue</para>
        /// </summary>
        [NameInMap("BudgetStatus")]
        [Validation(Required=false)]
        public string BudgetStatus { get; set; }

        /// <summary>
        /// <para>The type of the budget. Valid values: cost, byquantity, and asset. A value of cost specifies to filter expense budgets. A value of byquantity specifies to filter budgets calculated based on the resource usage. A value of asset specifies to filter usage or coverage budgets. By default, information about all budgets is returned if you do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cost</para>
        /// </summary>
        [NameInMap("BudgetType")]
        [Validation(Required=false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10. Maximum value: 10. Minimum value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position in which the query starts. You must set this parameter to null or the token that is obtained from the previous query. Otherwise, an error is returned. If you set the NextToken parameter to null, the query starts from the beginning. The default value is null.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6NH0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}

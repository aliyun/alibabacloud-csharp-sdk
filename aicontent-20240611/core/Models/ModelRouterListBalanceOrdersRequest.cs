// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterListBalanceOrdersRequest : TeaModel {
        /// <summary>
        /// <para>The balance type filter. Valid values: permanent, monthly. If this parameter is left empty, all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <para>The direction filter. Valid values: in (income), out (expenditure). If this parameter is left empty, all directions are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The maximum number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxx-xxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The change type filter. Valid values: recharge, periodic_recharge, manual_deduct, transfer_out, transfer_in, return_out, return_in, write_off, monthly_expire, and deficit_writeoff. If this parameter is left empty, all types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recharge</para>
        /// </summary>
        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

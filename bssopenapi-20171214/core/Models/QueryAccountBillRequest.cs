// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAccountBillRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account that owns and actually uses the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>122</para>
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// <para>The billing date. Format: YYYY-MM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-07</para>
        /// </summary>
        [NameInMap("BillingCycle")]
        [Validation(Required=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// <para>The billing date. This parameter is required only when you set Granularity to DAILY. Format: YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-01</para>
        /// </summary>
        [NameInMap("BillingDate")]
        [Validation(Required=false)]
        public string BillingDate { get; set; }

        /// <summary>
        /// <para>The granularity for querying the bill. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>MONTHLY: Queries bills on a monthly basis. Corresponds to the monthly bills in <b>Expenses &amp; Costs&#xA;</b>&gt; <b>Bills&#xA;</b>&gt; <b>Bill Details&#xA;</b>.</para>
        /// </description></item>
        /// <item><description><para>DAILY: Queries bills on a daily basis. Corresponds to the daily bills in <b>Expenses &amp; Costs&#xA;</b>&gt; <b>Bills&#xA;</b>&gt; <b>Bill Details&#xA;</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set <c>Granularity</c> to <c>DAILY</c>, you must also specify the <c>BillingDate</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MONTHLY</para>
        /// </summary>
        [NameInMap("Granularity")]
        [Validation(Required=false)]
        public string Granularity { get; set; }

        /// <summary>
        /// <para>Specifies whether to aggregate the results by product code.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Results are aggregated by product code.</para>
        /// </description></item>
        /// <item><description><para>false: Results are not aggregated by product code.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsGroupByProduct")]
        [Validation(Required=false)]
        public bool? IsGroupByProduct { get; set; }

        [NameInMap("OwnerID")]
        [Validation(Required=false)]
        public long? OwnerID { get; set; }

        /// <summary>
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The default value is 20. The maximum value is 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}

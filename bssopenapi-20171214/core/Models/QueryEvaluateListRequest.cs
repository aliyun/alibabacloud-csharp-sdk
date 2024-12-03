// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryEvaluateListRequest : TeaModel {
        /// <summary>
        /// <para>The billing cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202003</para>
        /// </summary>
        [NameInMap("BillCycle")]
        [Validation(Required=false)]
        public string BillCycle { get; set; }

        /// <summary>
        /// <para>The market types in invoices.</para>
        /// <remarks>
        /// <para> By default, this parameter is left empty. If this parameter is left empty, all market types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// <para>The maximum amount to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("EndAmount")]
        [Validation(Required=false)]
        public long? EndAmount { get; set; }

        /// <summary>
        /// <para>The latest time when an order is paid Specify the time in the yyyy-mm-dd hh:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-02 15:00:00</para>
        /// </summary>
        [NameInMap("EndBizTime")]
        [Validation(Required=false)]
        public string EndBizTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-02 12:00:00</para>
        /// </summary>
        [NameInMap("EndSearchTime")]
        [Validation(Required=false)]
        public string EndSearchTime { get; set; }

        /// <summary>
        /// <para>The ID of the external order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2387432832696</para>
        /// </summary>
        [NameInMap("OutBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the sort. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Sort invoices by ID in descending order.</description></item>
        /// <item><description>2: Sort invoices by invoice type in descending order, and then sort invoices of the same type by ID in descending order.</description></item>
        /// <item><description>3: Sort invoices by invoice type in ascending order, and then sort invoices of the same type by ID in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public int? SortType { get; set; }

        /// <summary>
        /// <para>The minimum amount to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StartAmount")]
        [Validation(Required=false)]
        public long? StartAmount { get; set; }

        /// <summary>
        /// <para>The earliest time when an order is paid. Specify the time in the yyyy-mm-dd hh:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-02 12:00:00</para>
        /// </summary>
        [NameInMap("StartBizTime")]
        [Validation(Required=false)]
        public string StartBizTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-02 12:00:00</para>
        /// </summary>
        [NameInMap("StartSearchTime")]
        [Validation(Required=false)]
        public string StartSearchTime { get; set; }

        /// <summary>
        /// <para>The type of orders to be queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: the orders in which the invoiceable amount is negative.</description></item>
        /// <item><description>2: the orders in which the invoiceable amount is positive.</description></item>
        /// <item><description>3: the orders in which the invoiceable amount is not 0.</description></item>
        /// <item><description>4: the orders in which the amount that has been invoiced is greater than 0.</description></item>
        /// </list>
        /// <remarks>
        /// <para> By default, this parameter is left empty. If this parameter is left empty, all orders are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}

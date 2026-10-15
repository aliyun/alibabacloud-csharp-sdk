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
        /// <para>202502</para>
        /// </summary>
        [NameInMap("BillCycle")]
        [Validation(Required=false)]
        public string BillCycle { get; set; }

        /// <summary>
        /// <para>The list of invoicing entities to which the invoiceable objects belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// <para>The maximum amount for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("EndAmount")]
        [Validation(Required=false)]
        public long? EndAmount { get; set; }

        /// <summary>
        /// <para>The end of the time range to query based on the successful payment time. The format is yyyy-mm-dd hh:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-01 00:00:00</para>
        /// </summary>
        [NameInMap("EndBizTime")]
        [Validation(Required=false)]
        public string EndBizTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-01 00:00:00</para>
        /// </summary>
        [NameInMap("EndSearchTime")]
        [Validation(Required=false)]
        public string EndSearchTime { get; set; }

        /// <summary>
        /// <para>The order ID, bill ID, or contract ID.</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: sorts the results by ID in descending order.</para>
        /// </description></item>
        /// <item><description><para>2: sorts the results by type in descending order, and then by ID in descending order.</para>
        /// </description></item>
        /// <item><description><para>3: sorts the results by type in ascending order, and then by ID in descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public int? SortType { get; set; }

        /// <summary>
        /// <para>The minimum amount for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StartAmount")]
        [Validation(Required=false)]
        public long? StartAmount { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query based on the successful payment time. The format is yyyy-mm-dd hh:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-02-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartBizTime")]
        [Validation(Required=false)]
        public string StartBizTime { get; set; }

        /// <summary>
        /// <para>The start of the time range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-02-01 00:00:00</para>
        /// </summary>
        [NameInMap("StartSearchTime")]
        [Validation(Required=false)]
        public string StartSearchTime { get; set; }

        /// <summary>
        /// <para>The type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: queries objects with a negative invoiceable amount.</para>
        /// </description></item>
        /// <item><description><para>2: queries objects with a positive invoiceable amount.</para>
        /// </description></item>
        /// <item><description><para>3: queries all objects with a non-zero invoiceable amount.</para>
        /// </description></item>
        /// <item><description><para>4: queries objects with an invoiced amount greater than 0.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you leave this parameter empty, all objects are queried.</para>
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

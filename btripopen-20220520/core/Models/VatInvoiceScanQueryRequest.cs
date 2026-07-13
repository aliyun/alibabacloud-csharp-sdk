// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class VatInvoiceScanQueryRequest : TeaModel {
        /// <summary>
        /// <para>The billing date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-01</para>
        /// </summary>
        [NameInMap("bill_date")]
        [Validation(Required=false)]
        public string BillDate { get; set; }

        /// <summary>
        /// <para>The bill ID.</para>
        /// <remarks>
        /// <para>Deprecated</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("bill_id")]
        [Validation(Required=false)]
        public long? BillId { get; set; }

        /// <summary>
        /// <para>The invoice subtask ID.</para>
        /// <remarks>
        /// <para>Deprecated</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>456</para>
        /// </summary>
        [NameInMap("invoice_sub_task_id")]
        [Validation(Required=false)]
        public long? InvoiceSubTaskId { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

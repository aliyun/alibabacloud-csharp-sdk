// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainTicketScanQueryRequest : TeaModel {
        /// <summary>
        /// <para>The billing date. If the billing date is not specified, you must specify the ticket serial number, ticket collection number, order ID, or invoice issue time.</para>
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
        /// <para>The invoice issue end time in yyyy-MM-dd HH:mm:ss format. If this parameter is specified, invoice_date_start must also be specified, and the time difference cannot exceed 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-05 00:00:00</para>
        /// </summary>
        [NameInMap("invoice_date_end")]
        [Validation(Required=false)]
        public string InvoiceDateEnd { get; set; }

        /// <summary>
        /// <para>The invoice issue start time in yyyy-MM-dd HH:mm:ss format. If this parameter is specified, invoice_date_end must also be specified, and the time difference cannot exceed 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-01 00:00:00</para>
        /// </summary>
        [NameInMap("invoice_date_start")]
        [Validation(Required=false)]
        public string InvoiceDateStart { get; set; }

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
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002145190081005400</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

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

        /// <summary>
        /// <para>The ticket serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32270201111333E012345</para>
        /// </summary>
        [NameInMap("serial_number")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The ticket collection number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D166E012345</para>
        /// </summary>
        [NameInMap("ticket_no")]
        [Validation(Required=false)]
        public string TicketNo { get; set; }

    }

}

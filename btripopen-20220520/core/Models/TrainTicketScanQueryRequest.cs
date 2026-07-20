// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainTicketScanQueryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-12-01</para>
        /// </summary>
        [NameInMap("bill_date")]
        [Validation(Required=false)]
        public string BillDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("bill_id")]
        [Validation(Required=false)]
        public long? BillId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-11-05 00:00:00</para>
        /// </summary>
        [NameInMap("invoice_date_end")]
        [Validation(Required=false)]
        public string InvoiceDateEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-11-01 00:00:00</para>
        /// </summary>
        [NameInMap("invoice_date_start")]
        [Validation(Required=false)]
        public string InvoiceDateStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>456</para>
        /// </summary>
        [NameInMap("invoice_sub_task_id")]
        [Validation(Required=false)]
        public long? InvoiceSubTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1002145190081005400</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32270201111333E012345</para>
        /// </summary>
        [NameInMap("serial_number")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D166E012345</para>
        /// </summary>
        [NameInMap("ticket_no")]
        [Validation(Required=false)]
        public string TicketNo { get; set; }

    }

}

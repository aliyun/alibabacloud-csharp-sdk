// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainTicketScanQueryRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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
        /// <para>456</para>
        /// </summary>
        [NameInMap("invoice_sub_task_id")]
        [Validation(Required=false)]
        public long? InvoiceSubTaskId { get; set; }

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

        [NameInMap("serial_number")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        [NameInMap("ticket_no")]
        [Validation(Required=false)]
        public string TicketNo { get; set; }

    }

}

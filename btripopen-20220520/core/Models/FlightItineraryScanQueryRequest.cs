// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightItineraryScanQueryRequest : TeaModel {
        /// <summary>
        /// <para>The billing date. If the billing date is not specified, you must specify the order ID, itinerary print serial number, or ticket number.</para>
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
        /// <para>The itinerary print serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234566</para>
        /// </summary>
        [NameInMap("itinerary_num")]
        [Validation(Required=false)]
        public string ItineraryNum { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017028203339982120</para>
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
        /// <para>The ticket number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>784-911111111</para>
        /// </summary>
        [NameInMap("ticket_no")]
        [Validation(Required=false)]
        public string TicketNo { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundApplyV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cheshiapi</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1683901850297448082</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1017002195370467137</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1019195836916039</para>
        /// </summary>
        [NameInMap("out_sub_order_id")]
        [Validation(Required=false)]
        public string OutSubOrderId { get; set; }

        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public string PassengerSegmentRelationsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("pre_cal_type")]
        [Validation(Required=false)]
        public int? PreCalType { get; set; }

        [NameInMap("refund_reason")]
        [Validation(Required=false)]
        public string RefundReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("refund_reason_type")]
        [Validation(Required=false)]
        public int? RefundReasonType { get; set; }

        [NameInMap("ticket_nos")]
        [Validation(Required=false)]
        public string TicketNosShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("total_refund_price")]
        [Validation(Required=false)]
        public long? TotalRefundPrice { get; set; }

        [NameInMap("upload_pict_urls")]
        [Validation(Required=false)]
        public string UploadPictUrls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("voluntary")]
        [Validation(Required=false)]
        public bool? Voluntary { get; set; }

    }

}

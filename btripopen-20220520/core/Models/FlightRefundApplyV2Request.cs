// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundApplyV2Request : TeaModel {
        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The business travel order ID. Either the external order ID or the business travel order ID is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683901850297448082</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The distribution external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467137</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The distribution external sub-order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1019195836916039</para>
        /// </summary>
        [NameInMap("out_sub_order_id")]
        [Validation(Required=false)]
        public string OutSubOrderId { get; set; }

        /// <summary>
        /// <para>The passenger-segment relations. This parameter is required when the refund dimension is passenger-segment.</para>
        /// </summary>
        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public List<FlightRefundApplyV2RequestPassengerSegmentRelations> PassengerSegmentRelations { get; set; }
        public class FlightRefundApplyV2RequestPassengerSegmentRelations : TeaModel {
            /// <summary>
            /// <para>The passenger ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1075004</para>
            /// </summary>
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public string PassengerId { get; set; }

            /// <summary>
            /// <para>The list of segment IDs.</para>
            /// </summary>
            [NameInMap("segment_id_list")]
            [Validation(Required=false)]
            public List<string> SegmentIdList { get; set; }

        }

        /// <summary>
        /// <para>The refund dimension. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Ticket number dimension.</description></item>
        /// <item><description>2: Passenger-segment dimension.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("pre_cal_type")]
        [Validation(Required=false)]
        public int? PreCalType { get; set; }

        /// <summary>
        /// <para>The refund reason description. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我要改变行程计划、我不想飞</para>
        /// </summary>
        [NameInMap("refund_reason")]
        [Validation(Required=false)]
        public string RefundReason { get; set; }

        /// <summary>
        /// <para>The refund reason type. This parameter is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Involuntary request (force majeure).</description></item>
        /// <item><description>2: Change of travel plan or no longer wish to fly.</description></item>
        /// <item><description>4: Voluntary refund (illness preventing travel without a certificate from a Grade II Level A hospital or above).</description></item>
        /// <item><description>5: Flight delay or cancellation, flight schedule change, or other airline-related reasons, or pandemic-related reasons.</description></item>
        /// <item><description>6: Health reasons with a certificate from a Grade II Level A hospital or above.</description></item>
        /// <item><description>7: Visa rejection or other force majeure factors.</description></item>
        /// <item><description>100: Involuntary deterministic emergency guidance.</description></item>
        /// <item><description>101: Involuntary non-deterministic emergency.</description></item>
        /// <item><description>200: Special refund.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("refund_reason_type")]
        [Validation(Required=false)]
        public int? RefundReasonType { get; set; }

        /// <summary>
        /// <para>The ticket numbers to refund. This parameter is required when the refund dimension is ticket number.</para>
        /// </summary>
        [NameInMap("ticket_nos")]
        [Validation(Required=false)]
        public List<string> TicketNos { get; set; }

        /// <summary>
        /// <para>The pre-calculated refund amount. This parameter is required after successful pre-calculation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("total_refund_price")]
        [Validation(Required=false)]
        public long? TotalRefundPrice { get; set; }

        /// <summary>
        /// <para>The refund attachment URLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>退票附件地址</para>
        /// </summary>
        [NameInMap("upload_pict_urls")]
        [Validation(Required=false)]
        public string UploadPictUrls { get; set; }

        /// <summary>
        /// <para>Specifies whether the refund is voluntary. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("voluntary")]
        [Validation(Required=false)]
        public bool? Voluntary { get; set; }

    }

}

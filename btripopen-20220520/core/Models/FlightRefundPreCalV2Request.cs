// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundPreCalV2Request : TeaModel {
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
        /// <para>3454043907950204159</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195370467137</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The passenger-segment relations. This parameter is required when the refund dimension is set to passenger-segment.</para>
        /// </summary>
        [NameInMap("passenger_segment_relations")]
        [Validation(Required=false)]
        public List<FlightRefundPreCalV2RequestPassengerSegmentRelations> PassengerSegmentRelations { get; set; }
        public class FlightRefundPreCalV2RequestPassengerSegmentRelations : TeaModel {
            /// <summary>
            /// <para>The passenger ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3243028</para>
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
        /// <item><description>1: ticket number dimension.</description></item>
        /// <item><description>2: passenger-segment dimension.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("pre_cal_type")]
        [Validation(Required=false)]
        public int? PreCalType { get; set; }

        /// <summary>
        /// <para>The ticket numbers to be refunded. This parameter is required when the refund dimension is set to ticket number.</para>
        /// </summary>
        [NameInMap("ticket_nos")]
        [Validation(Required=false)]
        public List<string> TicketNos { get; set; }

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

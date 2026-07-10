// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightRefundApplyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("out_refund_apply_id")]
        [Validation(Required=false)]
        public string OutRefundApplyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("passenger_journey_group_key")]
        [Validation(Required=false)]
        public string PassengerJourneyGroupKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_reason_code")]
        [Validation(Required=false)]
        public string RefundReasonCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_segment_list")]
        [Validation(Required=false)]
        public List<IntlFlightRefundApplyRequestRefundSegmentList> RefundSegmentList { get; set; }
        public class IntlFlightRefundApplyRequestRefundSegmentList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("segment_key")]
            [Validation(Required=false)]
            public string SegmentKey { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("selected_passengers")]
        [Validation(Required=false)]
        public List<IntlFlightRefundApplyRequestSelectedPassengers> SelectedPassengers { get; set; }
        public class IntlFlightRefundApplyRequestSelectedPassengers : TeaModel {
            [NameInMap("full_name")]
            [Validation(Required=false)]
            public string FullName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("passenger_id")]
            [Validation(Required=false)]
            public long? PassengerId { get; set; }

        }

    }

}

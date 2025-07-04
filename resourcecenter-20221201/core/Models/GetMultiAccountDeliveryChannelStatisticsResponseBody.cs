// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountDeliveryChannelStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics on the delivery channel.</para>
        /// </summary>
        [NameInMap("DeliveryChannelStatistics")]
        [Validation(Required=false)]
        public GetMultiAccountDeliveryChannelStatisticsResponseBodyDeliveryChannelStatistics DeliveryChannelStatistics { get; set; }
        public class GetMultiAccountDeliveryChannelStatisticsResponseBodyDeliveryChannelStatistics : TeaModel {
            /// <summary>
            /// <para>The ID of the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc-6q79dm4o9***</para>
            /// </summary>
            [NameInMap("DeliveryChannelId")]
            [Validation(Required=false)]
            public string DeliveryChannelId { get; set; }

            /// <summary>
            /// <para>The name of the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-multi-account-delivery</para>
            /// </summary>
            [NameInMap("DeliveryChannelName")]
            [Validation(Required=false)]
            public string DeliveryChannelName { get; set; }

            /// <summary>
            /// <para>The last delivery time of resource configuration change events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-03T16:05:15Z</para>
            /// </summary>
            [NameInMap("LatestChangeDeliveryTime")]
            [Validation(Required=false)]
            public string LatestChangeDeliveryTime { get; set; }

            /// <summary>
            /// <para>The last delivery time of scheduled resource snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-03T16:00:00Z</para>
            /// </summary>
            [NameInMap("LatestSnapshotDeliveryTime")]
            [Validation(Required=false)]
            public string LatestSnapshotDeliveryTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80DF0610-504C-56D7-BDCF-7C92FD687***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

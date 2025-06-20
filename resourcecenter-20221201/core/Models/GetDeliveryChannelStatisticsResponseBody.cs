// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetDeliveryChannelStatisticsResponseBody : TeaModel {
        [NameInMap("DeliveryChannelStatistics")]
        [Validation(Required=false)]
        public GetDeliveryChannelStatisticsResponseBodyDeliveryChannelStatistics DeliveryChannelStatistics { get; set; }
        public class GetDeliveryChannelStatisticsResponseBodyDeliveryChannelStatistics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dc-6q79dm4o9***</para>
            /// </summary>
            [NameInMap("DeliveryChannelId")]
            [Validation(Required=false)]
            public string DeliveryChannelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-delivery-channel</para>
            /// </summary>
            [NameInMap("DeliveryChannelName")]
            [Validation(Required=false)]
            public string DeliveryChannelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-03T16:05:15Z</para>
            /// </summary>
            [NameInMap("LatestChangeDeliveryTime")]
            [Validation(Required=false)]
            public string LatestChangeDeliveryTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-03T16:00:00Z</para>
            /// </summary>
            [NameInMap("LatestSnapshotDeliveryTime")]
            [Validation(Required=false)]
            public string LatestSnapshotDeliveryTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80DF0610-504C-56D7-BDCF-7C92FD687***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

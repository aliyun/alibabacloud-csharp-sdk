// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListDeliveryChannelsResponseBody : TeaModel {
        [NameInMap("DeliveryChannels")]
        [Validation(Required=false)]
        public List<ListDeliveryChannelsResponseBodyDeliveryChannels> DeliveryChannels { get; set; }
        public class ListDeliveryChannelsResponseBodyDeliveryChannels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-06-20T08:46:29Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DeliveryChannelDescription")]
            [Validation(Required=false)]
            public string DeliveryChannelDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dc-4m6ffpkgu***</para>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJzZWFyY2hBZnRlcnMiOlsiMTAwMTU2Nzk4MTU1OSJd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17502A1B-7026-5551-8E1C-CCABD0CBC***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListMultiAccountDeliveryChannelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The delivery channels.</para>
        /// </summary>
        [NameInMap("DeliveryChannels")]
        [Validation(Required=false)]
        public List<ListMultiAccountDeliveryChannelsResponseBodyDeliveryChannels> DeliveryChannels { get; set; }
        public class ListMultiAccountDeliveryChannelsResponseBodyDeliveryChannels : TeaModel {
            /// <summary>
            /// <para>The time when the delivery channel was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-17T00:23:55Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the delivery channel.</para>
            /// </summary>
            [NameInMap("DeliveryChannelDescription")]
            [Validation(Required=false)]
            public string DeliveryChannelDescription { get; set; }

            /// <summary>
            /// <para>The ID of the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc-0bzhsqpnk***</para>
            /// </summary>
            [NameInMap("DeliveryChannelId")]
            [Validation(Required=false)]
            public string DeliveryChannelId { get; set; }

            /// <summary>
            /// <para>The name of the delivery channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-multi-account-delivery-channel</para>
            /// </summary>
            [NameInMap("DeliveryChannelName")]
            [Validation(Required=false)]
            public string DeliveryChannelName { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJzZWFyY2hBZnRlcnMiOlsiMTAwMTU2Nzk4MTU1OSJd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17502A1B-7026-5551-8E1C-CCABD0CBC***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

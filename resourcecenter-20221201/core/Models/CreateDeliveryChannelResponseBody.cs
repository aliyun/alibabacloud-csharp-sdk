// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class CreateDeliveryChannelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dc-0bzhsqpnk***</para>
        /// </summary>
        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>42A89312-0616-591E-B614-07BC87D3D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

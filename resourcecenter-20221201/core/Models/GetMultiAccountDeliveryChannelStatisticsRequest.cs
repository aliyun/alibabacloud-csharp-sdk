// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountDeliveryChannelStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-6q79dm4o9***</para>
        /// </summary>
        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

    }

}

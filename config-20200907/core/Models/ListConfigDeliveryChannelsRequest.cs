// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigDeliveryChannelsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery channel. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdc-d9106457e0d900b1****</para>
        /// </summary>
        [NameInMap("DeliveryChannelIds")]
        [Validation(Required=false)]
        public string DeliveryChannelIds { get; set; }

    }

}

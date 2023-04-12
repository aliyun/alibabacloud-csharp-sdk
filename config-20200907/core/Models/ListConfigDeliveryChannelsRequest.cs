// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigDeliveryChannelsRequest : TeaModel {
        /// <summary>
        /// The ID of the delivery channel. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("DeliveryChannelIds")]
        [Validation(Required=false)]
        public string DeliveryChannelIds { get; set; }

    }

}

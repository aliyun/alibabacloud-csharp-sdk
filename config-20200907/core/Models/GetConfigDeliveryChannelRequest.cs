// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// The ID of the delivery channel.
        /// 
        /// For information about how to obtain the ID of a delivery channel, see [DescribeDeliveryChannels](~~429841~~).
        /// </summary>
        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

    }

}

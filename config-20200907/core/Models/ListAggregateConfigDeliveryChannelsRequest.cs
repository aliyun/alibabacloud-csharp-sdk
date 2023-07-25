// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigDeliveryChannelsRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// For more information about how to obtain the ID of the account group, see [ListAggregators](~~255797~~).
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The IDs of the delivery channels. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("DeliveryChannelIds")]
        [Validation(Required=false)]
        public string DeliveryChannelIds { get; set; }

    }

}

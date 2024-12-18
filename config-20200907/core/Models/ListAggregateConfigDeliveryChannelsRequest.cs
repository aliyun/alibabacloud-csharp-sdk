// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigDeliveryChannelsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of the account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-a4e5626622af0079****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>The IDs of the delivery channels. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdc-d9106457e0d900b1****</para>
        /// </summary>
        [NameInMap("DeliveryChannelIds")]
        [Validation(Required=false)]
        public string DeliveryChannelIds { get; set; }

    }

}

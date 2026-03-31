// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery channel.</para>
        /// <para>For more information about how to obtain the ID of a delivery channel, see <a href="https://help.aliyun.com/document_detail/429841.html">DescribeDeliveryChannels</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdc-d9106457e0d900b1****</para>
        /// </summary>
        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

    }

}

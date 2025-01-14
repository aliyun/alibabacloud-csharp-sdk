// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetSubscriptionAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the subscription.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySubscription</para>
        /// </summary>
        [NameInMap("SubscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// <para>The name of the topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTopic</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}

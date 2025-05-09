// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SetSubscriptionAttributesRequest : TeaModel {
        /// <summary>
        /// <para>The dead-letter queue policy.</para>
        /// </summary>
        [NameInMap("DlqPolicy")]
        [Validation(Required=false)]
        public SetSubscriptionAttributesRequestDlqPolicy DlqPolicy { get; set; }
        public class SetSubscriptionAttributesRequestDlqPolicy : TeaModel {
            /// <summary>
            /// <para>The queue to which dead-letter messages are delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deadLetterTargetQueue</para>
            /// </summary>
            [NameInMap("DeadLetterTargetQueue")]
            [Validation(Required=false)]
            public string DeadLetterTargetQueue { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the dead-letter message delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>The retry policy that is applied if an error occurs when Message Service (MNS) pushes messages to the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BACKOFF_RETRY</description></item>
        /// <item><description>EXPONENTIAL_DECAY_RETRY</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BACKOFF_RETRY</para>
        /// </summary>
        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

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
        /// <para>test</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}

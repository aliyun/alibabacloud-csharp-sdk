// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SetSubscriptionAttributesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The dead-letter queue policy.</para>
        /// </summary>
        [NameInMap("DlqPolicy")]
        [Validation(Required=false)]
        public string DlqPolicyShrink { get; set; }

        /// <summary>
        /// <para>The retry policy for message delivery failures to the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>BACKOFF_RETRY: backoff retry.</para>
        /// </description></item>
        /// <item><description><para>EXPONENTIAL_DECAY_RETRY: exponential decay retry.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BACKOFF_RETRY</para>
        /// </summary>
        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890:role/roleName</para>
        /// </summary>
        [NameInMap("StsRoleArn")]
        [Validation(Required=false)]
        public string StsRoleArn { get; set; }

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

        [NameInMap("TenantRateLimitPolicy")]
        [Validation(Required=false)]
        public string TenantRateLimitPolicyShrink { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SubscribeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The dead-letter queue policy.</para>
        /// </summary>
        [NameInMap("DlqPolicy")]
        [Validation(Required=false)]
        public string DlqPolicyShrink { get; set; }

        [NameInMap("DmAttributes")]
        [Validation(Required=false)]
        public string DmAttributesShrink { get; set; }

        [NameInMap("DysmsAttributes")]
        [Validation(Required=false)]
        public string DysmsAttributesShrink { get; set; }

        /// <summary>
        /// <para>The receiver endpoint. The format of the endpoint varies based on the terminal type.</para>
        /// <list type="bullet">
        /// <item><description>If you set PushType to http, set Endpoint to an <c>HTTP URL that starts with http:// or https://</c>.</description></item>
        /// <item><description>If you set PushType to queue, set Endpoint to a <c>queue name</c>.</description></item>
        /// <item><description>If you set PushType to mpush, set Endpoint to an <c>AppKey</c>.</description></item>
        /// <item><description>If you set PushType to alisms, set Endpoint to a <c>mobile number</c>.</description></item>
        /// <item><description>If you set PushType to email, set Endpoint to an <c>email address</c>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com">http://example.com</a></para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("KafkaAttributes")]
        [Validation(Required=false)]
        public string KafkaAttributesShrink { get; set; }

        /// <summary>
        /// <para>The tag that is used to filter messages. Only messages that have the same tag can be pushed. Set the value to a string of no more than 16 characters.</para>
        /// <para>By default, no tag is specified to filter messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>important</para>
        /// </summary>
        [NameInMap("MessageTag")]
        [Validation(Required=false)]
        public string MessageTag { get; set; }

        /// <summary>
        /// <para>The content format of the messages that are pushed to the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>XML</description></item>
        /// <item><description>JSON</description></item>
        /// <item><description>SIMPLIFIED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>XML</para>
        /// </summary>
        [NameInMap("NotifyContentFormat")]
        [Validation(Required=false)]
        public string NotifyContentFormat { get; set; }

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
        /// <para>The terminal type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>http: HTTP services</description></item>
        /// <item><description>queue: queues</description></item>
        /// <item><description>mpush: mobile devices</description></item>
        /// <item><description>alisms: Alibaba Cloud Short Message Service (SMS)</description></item>
        /// <item><description>email: emails</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>queue</para>
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        [NameInMap("StsRoleArn")]
        [Validation(Required=false)]
        public string StsRoleArn { get; set; }

        /// <summary>
        /// <para>The name of the subscription.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSubscription</para>
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

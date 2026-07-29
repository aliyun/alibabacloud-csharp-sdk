// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SubscribeRequest : TeaModel {
        /// <summary>
        /// <para>The dead-letter queue policy.</para>
        /// </summary>
        [NameInMap("DlqPolicy")]
        [Validation(Required=false)]
        public SubscribeRequestDlqPolicy DlqPolicy { get; set; }
        public class SubscribeRequestDlqPolicy : TeaModel {
            /// <summary>
            /// <para>The destination queue for dead-letter message delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deadLetterTargetQueue</para>
            /// </summary>
            [NameInMap("DeadLetterTargetQueue")]
            [Validation(Required=false)]
            public string DeadLetterTargetQueue { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable dead-letter message delivery.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>The email push attributes. This parameter is required when PushType is set to dm. The value is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>AccountName: The sender address configured in DirectMail (such as <a href="mailto:notify@example.com">notify@example.com</a>).</description></item>
        /// <item><description>Subject: The email subject.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DmAttributes")]
        [Validation(Required=false)]
        public SubscribeRequestDmAttributes DmAttributes { get; set; }
        public class SubscribeRequestDmAttributes : TeaModel {
            /// <summary>
            /// <para>The sender address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:notify@example.com">notify@example.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The email subject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>notify</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        /// <summary>
        /// <para>The SMS push attributes. This parameter is required when PushType is set to alisms. The value is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description>TemplateCode: The SMS template code, which can be obtained from the Short Message Service console.</description></item>
        /// <item><description>SignName: The SMS signature name.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DysmsAttributes")]
        [Validation(Required=false)]
        public SubscribeRequestDysmsAttributes DysmsAttributes { get; set; }
        public class SubscribeRequestDysmsAttributes : TeaModel {
            /// <summary>
            /// <para>The SMS signature name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云短信测试专用</para>
            /// </summary>
            [NameInMap("SignName")]
            [Validation(Required=false)]
            public string SignName { get; set; }

            /// <summary>
            /// <para>The SMS template code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <h2>Endpoint address for receiving messages</h2>
        /// <para>The format varies depending on the value of <c>PushType</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>PushType=http</c>: An HTTP/HTTPS callback URL, such as <c>http://example.com/callback</c> or <c>https://example.com/callback</c>.</description></item>
        /// <item><description><c>PushType=queue</c>: The ARN of the destination queue, in the format <c>acs:mns:{RegionId}:{Alibaba Cloud account ID}:queues/{QueueName}</c>.</description></item>
        /// <item><description><c>PushType=dm</c>: The email push endpoint, in the fixed format <c>smq-ep:dm:{Alibaba Cloud account ID}:__dynamic</c>. Replace <c>{Alibaba Cloud account ID}</c> with your Alibaba Cloud account ID.</description></item>
        /// <item><description><c>PushType=dysms</c>: The SMS push endpoint, in the format <c>smq-ep:dysms:{Alibaba Cloud account ID}:{PhoneNumber}</c>.</description></item>
        /// <item><description><c>PushType=kafka</c>: The Kafka push endpoint. The Kafka push type is deprecated.</description></item>
        /// <item><description><c>PushType=fc</c>: The Function Compute endpoint, in the format <c>acs:fc:{RegionId}:{Alibaba Cloud account ID}:services/{ServiceName}/functions/{FunctionName}</c>.</description></item>
        /// <item><description><c>PushType=eventbus</c>: The EventBridge endpoint, in the format <c>acs:eventbridge:{RegionId}:{Alibaba Cloud account ID}:eventbus/{EventBusName}</c>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://*****.com/uri1/xxx</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The Kafka push type is deprecated.</para>
        /// </summary>
        [NameInMap("KafkaAttributes")]
        [Validation(Required=false)]
        public SubscribeRequestKafkaAttributes KafkaAttributes { get; set; }
        public class SubscribeRequestKafkaAttributes : TeaModel {
            /// <summary>
            /// <para>The Kafka push type is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default empty string</para>
            /// </summary>
            [NameInMap("BusinessMode")]
            [Validation(Required=false)]
            public string BusinessMode { get; set; }

        }

        /// <summary>
        /// <para>The tag used for message filtering in this subscription. Only messages with a matching tag are pushed. The value is a string of up to 16 characters.</para>
        /// <para>By default, no message filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>important</para>
        /// </summary>
        [NameInMap("MessageTag")]
        [Validation(Required=false)]
        public string MessageTag { get; set; }

        /// <summary>
        /// <h2>Format of the pushed message content</h2>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>XML</c>: The message body is pushed in XML format. This is the default value.</description></item>
        /// <item><description><c>JSON</c>: The message body is pushed in JSON format.</description></item>
        /// <item><description><c>SIMPLIFIED</c>: Only the raw message body content is pushed, without SMQ metadata wrapping.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>XML</para>
        /// </summary>
        [NameInMap("NotifyContentFormat")]
        [Validation(Required=false)]
        public string NotifyContentFormat { get; set; }

        /// <summary>
        /// <para>The retry strategy when an error occurs while pushing messages to the endpoint. Valid values:</para>
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
        /// <h2>Push type of the subscription</h2>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>http</c>: HTTP/HTTPS push. Pushes messages to a specified HTTP or HTTPS callback URL.</para>
        /// </description></item>
        /// <item><description><para><c>queue</c>: Queue push. Pushes messages to a specified SMQ queue.</para>
        /// </description></item>
        /// <item><description><para><c>dm</c>: Email push. Sends notifications through DirectMail. You must also set the <c>DmAttributes</c> and <c>StsRoleArn</c> parameters.</para>
        /// </description></item>
        /// <item><description><para><c>dysms</c>: SMS push. Sends notifications through Alibaba Cloud Short Message Service. You must also set the <c>DysmsAttributes</c> parameter.</para>
        /// </description></item>
        /// <item><description><para><c>fc</c>: Function Compute push. Pushes messages to Alibaba Cloud Function Compute (FC).</para>
        /// </description></item>
        /// <item><description><para><c>eventbus</c>: EventBridge push. Pushes messages to an EventBridge event bus.</para>
        /// </description></item>
        /// </list>
        /// <para><b>Note:</b>
        /// The following values are deprecated and are only used for compatibility with legacy subscriptions:</para>
        /// <list type="bullet">
        /// <item><description><c>mpush</c>: Mobile push.</description></item>
        /// <item><description><c>alisms</c>: Legacy SMS.</description></item>
        /// <item><description><c>email</c>: Legacy email. Use <c>dm</c> instead.</description></item>
        /// <item><description><c>kafka</c>: Kafka push type is deprecated.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>queue</para>
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role assumed by the service. The format is acs:ram::{Alibaba Cloud account ID}:role/{RoleName}. Replace {Alibaba Cloud account ID} with the Alibaba Cloud account ID that calls the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890:role/AliyunMNSNotificationRole</para>
        /// </summary>
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

        /// <summary>
        /// <para>The throttling policy.</para>
        /// </summary>
        [NameInMap("TenantRateLimitPolicy")]
        [Validation(Required=false)]
        public SubscribeRequestTenantRateLimitPolicy TenantRateLimitPolicy { get; set; }
        public class SubscribeRequestTenantRateLimitPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the throttling policy. Valid values: true and false.</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The maximum number of pushes or consumptions per second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("MaxReceivesPerSecond")]
            [Validation(Required=false)]
            public int? MaxReceivesPerSecond { get; set; }

        }

        /// <summary>
        /// <para>The name of the topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic****1</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}

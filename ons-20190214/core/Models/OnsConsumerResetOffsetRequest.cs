// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerResetOffsetRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the consumer group whose dead-letter message you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_test_consumer_id</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the consumer group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The timestamp to which you want to reset the consumer offset. This parameter takes effect only when the <b>Type</b> parameter is set to <b>1</b>. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1591153871000</para>
        /// </summary>
        [NameInMap("ResetTimestamp")]
        [Validation(Required=false)]
        public long? ResetTimestamp { get; set; }

        /// <summary>
        /// <para>The name of the topic for which you want to reset the consumer offset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-mq-topic</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The method that you want to use to clear accumulated messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0:</b> All accumulated messages are cleared. Messages that are not consumed are ignored. Consumers in the specified consumer group consume only messages that are published to the topic after the specified point in time.</description></item>
        /// </list>
        /// <para>If &quot;reconsumeLater&quot; is returned, the accumulated messages are not cleared because the system is retrying to resend the messages to consumers.</para>
        /// <list type="bullet">
        /// <item><description><b>1:</b> The messages that were published to the topic before the specified point in time are cleared. You must specify a point in time. Consumers in the specified consumer group consume only the messages that are published to the topic after the specified point in time.</description></item>
        /// </list>
        /// <para>You can specify a point in time from the earliest point in time when a message was published to the topic to the most recent point in time when a message was published to the topic. Points in time that are not within the allowed time range are invalid.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}

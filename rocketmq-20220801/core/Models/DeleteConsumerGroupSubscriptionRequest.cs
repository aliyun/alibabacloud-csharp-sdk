// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class DeleteConsumerGroupSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The filter expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("filterExpression")]
        [Validation(Required=false)]
        public string FilterExpression { get; set; }

        /// <summary>
        /// <para>The type of the filter expression. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SQL: filters messages by using SQL expressions.</description></item>
        /// <item><description>TAG: filters messages by using tags.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TAG</para>
        /// </summary>
        [NameInMap("filterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// <para>The topic name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic_test</para>
        /// </summary>
        [NameInMap("topicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}

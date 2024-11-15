// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpdateConsumerOffsetShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the consumer group.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must be <b>3 to 64</b> characters in length. If a name contains more than <b>64</b> characters, the name is automatically truncated.</description></item>
        /// <item><description>The name of a consumer group cannot be changed after the consumer group is created.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kafka-test</para>
        /// </summary>
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-mp91inkw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>If you set resetType to offset, you can use this parameter to reset the consumer offset of each partition of a specific topic in the consumer group.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Offsets")]
        [Validation(Required=false)]
        public string OffsetsShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the instance to which the consumer group belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The method that is used to reset the consumer offsets of the subscribed topics of a consumer group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>timestamp</b> (default)</description></item>
        /// <item><description><b>offset</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>timestamp</para>
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

        /// <summary>
        /// <para>The point in time when message consumption starts. The value of this parameter is a UNIX timestamp in milliseconds. The value of this parameter must be <b>less than 0</b> or <b>within the retention period of the consumer offset</b>. This parameter takes effect only if you set resetType to timestamp.</para>
        /// <list type="bullet">
        /// <item><description>If you want to reset the consumer offset to the latest offset, set this parameter to -1.</description></item>
        /// <item><description>If you want to reset the consumer offset to the earliest offset, set this parameter to -2.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <para>The topic name.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The name must be <b>3 to 64</b> characters in length. If a name contains more than <b>64</b> characters, the name is automatically truncated.</description></item>
        /// <item><description>The name of a topic cannot be changed after the topic is created.</description></item>
        /// </list>
        /// <para><b>If you want to reset the consumer offsets of all topics to which the consumer subscribes, specify an empty string.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic_name</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

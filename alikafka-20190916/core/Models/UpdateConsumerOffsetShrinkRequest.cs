// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpdateConsumerOffsetShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Consumer Group name.</para>
        /// <list type="bullet">
        /// <item><description><para>Can only contain letters, numbers, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>Length must be <b>3-64</b> characters. If more than <b>64</b> characters are provided, they will be automatically truncated.</para>
        /// </description></item>
        /// <item><description><para>Cannot be modified once created.</para>
        /// </description></item>
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
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-mp91inkw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>When resetType is offset, this parameter is used to set the consumer offset for each partition of a topic for the consumer group.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Offsets")]
        [Validation(Required=false)]
        public string OffsetsShrink { get; set; }

        /// <summary>
        /// <para>Region ID of the instance to which the Group belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Type of consumer group offset reset, supporting the following two types:</para>
        /// <list type="bullet">
        /// <item><description><para><b>timestamp</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>offset</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>timestamp</para>
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

        /// <summary>
        /// <para>Time parameter in Unix timestamp format, in milliseconds.
        /// The parameter range should be <b>less than 0</b> or <b>within the retention period of the consumer offset</b>. This parameter only takes effect when resetType is timestamp.</para>
        /// <list type="bullet">
        /// <item><description><para>To reset to the latest consumer offset, pass -1.</para>
        /// </description></item>
        /// <item><description><para>To reset to the earliest consumer offset, pass -2.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <para>Topic name.</para>
        /// <list type="bullet">
        /// <item><description><para>Can only contain letters, numbers, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Length must be <b>3-64</b> characters. If more than <b>64</b> characters are provided, they will be automatically truncated.</para>
        /// </description></item>
        /// <item><description><para>Cannot be modified once created.</para>
        /// </description></item>
        /// </list>
        /// <para><b>To set the consumer offset for all topics subscribed by the current consumer, pass an empty string.</b></para>
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

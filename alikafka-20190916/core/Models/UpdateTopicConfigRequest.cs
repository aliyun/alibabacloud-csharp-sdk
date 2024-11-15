// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpdateTopicConfigRequest : TeaModel {
        /// <summary>
        /// <para>The key of the topic configuration.</para>
        /// <list type="bullet">
        /// <item><description>ApsaraMQ for Kafka V2 instances allow you to modify configurations only for topics that use local storage.</description></item>
        /// <item><description>ApsaraMQ for Kafka V3 instances allow you to modify configurations for all topics.</description></item>
        /// <item><description>The following keys are supported by <c>local topic</c> of ApsaraMQ for Kafka V2 instances: retention.ms, retention.bytes, and replications.</description></item>
        /// <item><description>The following keys are supported by ApsaraMQ for Kafka V3 instances: retention.hours and max.message.bytes.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>replications</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-v0h1fgs2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The topic name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dqc_test2</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The configuration item that you want to update for the topic. The following configuration items are supported by ApsaraMQ for Kafka V3 instances:</para>
        /// <list type="bullet">
        /// <item><description><c>retention.hours</c> specifies the message retention period. Value type: string. Valid values: 24 to 8760.</description></item>
        /// <item><description><c>max.message.bytes</c> specifies the maximum size of a sent message. Value type: string. Valid values: 1048576 to 10485760.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}

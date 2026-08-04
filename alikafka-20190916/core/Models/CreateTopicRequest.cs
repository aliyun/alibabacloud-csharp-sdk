// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// <para>The cleanup policy configured when the storage engine of the topic is set to local storage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: delete cleanup policy.</description></item>
        /// <item><description>true: compact cleanup policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CompactTopic")]
        [Validation(Required=false)]
        public bool? CompactTopic { get; set; }

        /// <summary>
        /// <para>The supplementary configuration.</para>
        /// <list type="bullet">
        /// <item><description><para>Must be in JSON format.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only when <b>LocalTopic</b> is set to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>Supported configurations for reserved instances:</para>
        /// <list type="bullet">
        /// <item><description><b>retention.ms</b> (message retention period): ranges from 3600000 to 31536000000 milliseconds.</description></item>
        /// <item><description><b>max.message.bytes</b> (maximum message size): ranges from 1048576 to 10485760 bytes. </description></item>
        /// <item><description><b>message.timestamp.type</b>: specifies the type of message timestamp. CreateTime indicates the timestamp specified by the producer when sending a message. If not specified, it is the message creation time on the client. LogAppendTime indicates the time when the message is written to disk on the server. Valid values: CreateTime or LogAppendTime. Default value: CreateTime. We recommend LogAppendTime.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Supported configurations for Serverless instances:</para>
        /// <list type="bullet">
        /// <item><description><b>retention.hours</b> (message retention period): value type is String. Valid values: 24 to 8760.</description></item>
        /// <item><description><b>max.message.bytes</b> (maximum message size): value type is String. Valid values: 1048576 to 10485760.</description></item>
        /// <item><description><b>message.timestamp.type</b> (type of message timestamp): CreateTime indicates the timestamp specified by the producer when sending a message. If not specified, it is the message creation time on the client. LogAppendTime indicates the time when the message is written to disk on the server. Valid values: CreateTime or LogAppendTime. Default value: CreateTime. We recommend LogAppendTime.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;retention.ms&quot;: &quot;3600000&quot;}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_pre-cn-mp919o4v****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The storage engine of the topic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: cloud storage.</description></item>
        /// <item><description>true: local storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LocalTopic")]
        [Validation(Required=false)]
        public bool? LocalTopic { get; set; }

        /// <summary>
        /// <para>The minimum number of in-sync replicas (ISR).</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when <b>LocalTopic</b> is set to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>The value must be less than the number of topic replicas.</para>
        /// </description></item>
        /// <item><description><para>The number of in-sync replicas ranges from 1 to 3.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("MinInsyncReplicas")]
        [Validation(Required=false)]
        public long? MinInsyncReplicas { get; set; }

        /// <summary>
        /// <para>The number of partitions for the topic.</para>
        /// <list type="bullet">
        /// <item><description><para>The number of partitions ranges from 1 to 360.</para>
        /// </description></item>
        /// <item><description><para>The console provides different configuration suggestions based on the instance edition. Configure the number of partitions based on the console suggestions to reduce the risk of data skew.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>Reserved instances: 12</para>
        /// </description></item>
        /// <item><description><para>Serverless instances: 3</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public string PartitionNum { get; set; }

        /// <summary>
        /// <para>The region ID of the instance to which the topic belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The description of the topic.</para>
        /// <list type="bullet">
        /// <item><description><para>Can contain only letters, digits, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Must be 3 to 64 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_topic_test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The number of replicas for the topic.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when <b>LocalTopic</b> is set to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>The number of replicas ranges from 1 to 3.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the number of replicas is set to <b>1</b>, data loss may occur. Set this parameter with caution.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public long? ReplicationFactor { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTopicRequestTag> Tag { get; set; }
        public class CreateTopicRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>N ranges from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is left empty, all tag keys are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>N ranges from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>This parameter can be left empty.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length and cannot start with aliyun or acs:, or contain http:// or https://.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the topic.</para>
        /// <list type="bullet">
        /// <item><description>Reserved instances:
        /// Supports uppercase and lowercase letters, digits, underscores (_), hyphens (-), and periods (.). The name must be 3 to 64 characters in length.</description></item>
        /// <item><description>Serverless instances:
        /// Supports uppercase and lowercase letters, digits, underscores (_), hyphens (-), and periods (.). The name must be 1 to 249 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_topic_test</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

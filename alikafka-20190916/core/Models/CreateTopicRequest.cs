// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// <para>The log cleanup policy that is used for the topic. This parameter is available only when LocalTopic is set to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: The topic uses the default log cleanup policy.</description></item>
        /// <item><description>true: The topic uses the log compaction policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CompactTopic")]
        [Validation(Required=false)]
        public bool? CompactTopic { get; set; }

        /// <summary>
        /// <para>The additional configurations.</para>
        /// <list type="bullet">
        /// <item><description>The value must be in JSON format.</description></item>
        /// <item><description>Set Key to <b>replications</b>. This value specifies the number of replicas of the topic. The value must be an integer that ranges from 1 to 3.</description></item>
        /// <item><description>You can configure this parameter only if you set <b>LocalTopic</b> to <b>true</b> or specify <b>Open Source Edition (Local Disk)</b> as the instance edition.****</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you specify replications in this parameter, <b>ReplicationFactor</b> does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;replications&quot;: 3}</para>
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
        /// <para>The type of storage that the topic uses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: The topic uses cloud storage.</description></item>
        /// <item><description>true: The topic uses local storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LocalTopic")]
        [Validation(Required=false)]
        public bool? LocalTopic { get; set; }

        /// <summary>
        /// <para>The minimum number of in-sync replicas (ISRs).</para>
        /// <list type="bullet">
        /// <item><description>This parameter is available only when <b>LocalTopic</b> is set to <b>true</b>, or the instance is of the <b>Open Source Edition (Local Disk)</b>.****</description></item>
        /// <item><description>The value of this parameter must be smaller than the value of ReplicationFactor.</description></item>
        /// <item><description>Valid values: 1 to 3.</description></item>
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
        /// <para>The number of partitions in the topic.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 360.</description></item>
        /// <item><description>In the ApsaraMQ for Kafka console, you can view the number of partitions that the system recommends based on the specifications of the instance. We recommend that you specify the number that is recommended by the system as the value of this parameter to reduce the risk of data skew.</description></item>
        /// </list>
        /// <para>Default values:</para>
        /// <list type="bullet">
        /// <item><description>ApsaraMQ for Kafka V2 instance: 12</description></item>
        /// <item><description>ApsaraMQ for Kafka V3 instance: 3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public string PartitionNum { get; set; }

        /// <summary>
        /// <para>The region ID of the instance in which you want to create a topic.</para>
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
        /// <item><description>The description can contain only letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The description must be 3 to 64 characters in length.</description></item>
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
        /// <item><description>This parameter is available only when <b>LocalTopic</b> is set to <b>true</b>, or the instance is of the <b>Open Source Edition (Local Disk)</b>.****</description></item>
        /// <item><description>Valid values: 1 to 3.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to <b>1</b>, data loss may occur. Exercise caution when you configure this parameter.</para>
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
        /// <para>The tags that you want to add to the topic.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTopicRequestTag> Tag { get; set; }
        public class CreateTopicRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <list type="bullet">
            /// <item><description>If you do not specify this parameter, the keys of all tags are matched.</description></item>
            /// <item><description>The tag key must be 1 to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
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
            /// <para>The tag value.</para>
            /// <list type="bullet">
            /// <item><description>You can leave this parameter empty.</description></item>
            /// <item><description>The tag value must be 1 to 128 characters in length and cannot contain http:// or https://. The tag value cannot start with aliyun or acs:.</description></item>
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
        /// <para>The topic name.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must be 3 to 64 characters in length. If the name that you specify contains more than 64 characters, the system automatically truncates the name.</description></item>
        /// <item><description>After a topic is created, you cannot change the name of the topic.</description></item>
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

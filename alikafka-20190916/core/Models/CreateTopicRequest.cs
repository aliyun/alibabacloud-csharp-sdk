// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateTopicRequest : TeaModel {
        /// <summary>
        /// <para>The cleanup policy for the topic. This parameter is available only if the storage engine of the topic is local storage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: The delete cleanup policy.</para>
        /// </description></item>
        /// <item><description><para>true: The compact cleanup policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CompactTopic")]
        [Validation(Required=false)]
        public bool? CompactTopic { get; set; }

        /// <summary>
        /// <para>The advanced configurations of the topic.</para>
        /// <list type="bullet">
        /// <item><description><para>Configure this parameter in the JSON format.</para>
        /// </description></item>
        /// <item><description><para>This parameter is available only if <b>LocalTopic</b> is set to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>The following configurations are supported for reserved instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>retention.ms</b>: The message retention period. The value must be an integer from 3,600,000 to 31,536,000,000. Unit: milliseconds.</para>
        /// </description></item>
        /// <item><description><para><b>max.message.bytes</b>: The maximum size of a message that can be sent. The value must be an integer from 1,048,576 to 10,485,760. Unit: bytes.</para>
        /// </description></item>
        /// <item><description><para>message.timestamp.type: The timestamp type of a message. Valid values: CreateTime or LogAppendTime. CreateTime indicates that the message timestamp is the time when the producer creates the message. If you do not specify a timestamp, the client time is used. LogAppendTime indicates that the message timestamp is the time when the server stores the message. The default value is CreateTime. We recommend that you set this parameter to <b>LogAppendTime</b>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The following configurations are supported for Serverless instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>retention.hours</b>: The message retention period. The value is of the string type. The value must be an integer from 24 to 8,760.</para>
        /// </description></item>
        /// <item><description><para><b>max.message.bytes</b>: The maximum size of a message that can be sent. The value is of the string type. The value must be an integer from 1,048,576 to 10,485,760.</para>
        /// </description></item>
        /// <item><description><para>message.timestamp.type: The timestamp type of a message. Valid values: CreateTime or LogAppendTime. CreateTime indicates that the message timestamp is the time when the producer creates the message. If you do not specify a timestamp, the client time is used. LogAppendTime indicates that the message timestamp is the time when the server stores the message. The default value is CreateTime. We recommend that you set this parameter to <b>LogAppendTime</b>.</para>
        /// </description></item>
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
        /// <para>The ID of the instance.</para>
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
        /// <item><description><para>false: cloud storage.</para>
        /// </description></item>
        /// <item><description><para>true: local storage.</para>
        /// </description></item>
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
        /// <item><description><para>This parameter is available only if <b>LocalTopic</b> is set to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>The value of this parameter must be smaller than the number of replicas for the topic.</para>
        /// </description></item>
        /// <item><description><para>The value must be an integer from 1 to 3.</para>
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
        /// <para>The number of partitions in the topic.</para>
        /// <list type="bullet">
        /// <item><description><para>The value must be an integer from 1 to 360.</para>
        /// </description></item>
        /// <item><description><para>The console suggests a number of partitions based on the instance type. Follow the suggestion to reduce the risk of data skew.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>Reserved instance: 12</para>
        /// </description></item>
        /// <item><description><para>Serverless instance: 3</para>
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
        /// <para>The ID of the region where the instance that contains the topic is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The remarks on the topic.</para>
        /// <list type="bullet">
        /// <item><description><para>The remarks can contain only letters, digits, underscores (_), and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>The remarks must be 3 to 64 characters in length.</para>
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
        /// <item><description><para>This parameter is available only if <b>LocalTopic</b> is set to <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>The value must be an integer from 1 to 3.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set the number of replicas to <b>1</b>, you may lose data. Set this parameter with caution.</para>
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
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTopicRequestTag> Tag { get; set; }
        public class CreateTopicRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>N specifies the number of the tag. The value of N must be an integer from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is left empty, all tag keys are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
            /// <item><description><para>N specifies the number of the tag. The value of N must be an integer from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be empty.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length. It cannot start with aliyun or acs:, and cannot contain http\:// or https\://.</para>
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
        /// <item><description><para>Reserved instance: The name can contain uppercase letters, lowercase letters, digits, underscores (_), hyphens (-), and periods (.). The name must be 3 to 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>Serverless instance: The name can contain uppercase letters, lowercase letters, digits, underscores (_), hyphens (-), and periods (.). The name must be 1 to 249 characters in length.</para>
        /// </description></item>
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

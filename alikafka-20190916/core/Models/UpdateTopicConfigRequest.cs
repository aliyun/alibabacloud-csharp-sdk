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
        /// <item><description>For reserved instances, you can modify only the configurations of the topics that use local storage.</description></item>
        /// <item><description>For serverless instances, you can modify the configurations of all topics.</description></item>
        /// <item><description>Reserved instances whose topics use local storage support the following keys: retention.ms, max.message.bytes, replications, message.timestamp.type, and message.timestamp.difference.max.ms.``</description></item>
        /// <item><description>Serverless instances support the following keys: retention.hours, max.message.bytes, message.timestamp.type, message.timestamp.difference.max.ms.</description></item>
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
        /// <para>The value of the topic configuration.</para>
        /// <list type="bullet">
        /// <item><description><para>Serverless instances support the following values:</para>
        /// <list type="bullet">
        /// <item><description><c>retention.hours</c>: the message retention period. Value type: string. Valid values: 24 to 8760.</description></item>
        /// <item><description><c>max.message.bytes</c>: the maximum size of a sent message. Value type: string. Valid values: 1048576 to 10485760.</description></item>
        /// <item><description><c>message.timestamp.type</c>: the timestamp type of a message. Valid values: CreateTime and LogAppendTime. The value CreateTime specifies the timestamp that is specified by the producer when the message is sent. The value LogAppendTime specifies the time when the broker appends the message to its log. If you do not specify this parameter, the time when the message is created on the client is used.</description></item>
        /// <item><description><c>message.timestamp.difference.max.ms</c>: the maximum positive or negative difference allowed between the timestamp when the broker receives a message and the timestamp specified in the message. If you set message.timestamp.type to CreateTime, <b>a message is rejected</b> if the difference in timestamp exceeds the threshold. If you set message.timestamp.type to LogAppendTime, this configuration does not take effect.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Reserved instances support the following values:</para>
        /// <list type="bullet">
        /// <item><description><c>retention.ms</c>: the message retention period. Value type: string. Valid values: 3600000 to 31536000000.</description></item>
        /// <item><description><c>max.message.bytes</c>: the maximum size of a sent message. Value type: string. Valid values: 1048576 to 10485760.</description></item>
        /// <item><description><c>replications</c>: the number of replicas. Value type: string. Valid values: 1 to 3.</description></item>
        /// <item><description><c>message.timestamp.type</c>: the timestamp type of a message. Valid values: CreateTime and LogAppendTime. The value CreateTime specifies the timestamp that is specified by the producer when the message is sent. The value LogAppendTime specifies the time when the broker appends the message to its log. If you do not specify this parameter, the time when the message is created on the client is used.</description></item>
        /// <item><description><c>message.timestamp.difference.max.ms</c>: the maximum positive or negative difference allowed between the timestamp when the broker receives a message and the timestamp specified in the message. If you set message.timestamp.type to CreateTime, <b>a message is rejected</b> if the difference in timestamp exceeds the threshold. If you set message.timestamp.type to LogAppendTime, this configuration does not take effect.</description></item>
        /// </list>
        /// </description></item>
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

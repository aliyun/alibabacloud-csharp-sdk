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
        /// <item><description><para>You can modify the configurations only for topics that use the local storage engine on reserved instances. You cannot modify the configurations for topics that use the cloud storage engine.</para>
        /// </description></item>
        /// <item><description><para>You can modify the configurations of topics for Serverless instances.</para>
        /// </description></item>
        /// <item><description><para>For <c>local topics</c> on reserved instances, the supported keys are \<c>retention.ms\\</c>, \<c>max.message.bytes\\</c>, \<c>message.timestamp.type\\</c>, and \<c>message.timestamp.difference.max.ms\\</c>.</para>
        /// </description></item>
        /// <item><description><para>For Serverless instances, the supported keys are \<c>retention.hours\\</c>, \<c>max.message.bytes\\</c>, \<c>message.timestamp.type\\</c>, and \<c>message.timestamp.difference.max.ms\\</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>retention.ms</para>
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
        /// <para>The region ID of the instance.</para>
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
        /// <item><description><para>The following configurations are supported for Serverless instances:</para>
        /// <list type="bullet">
        /// <item><description><para><c>retention.hours</c> specifies the message retention period. The value must be a string. The value must be in the range of 24 to 8,760.</para>
        /// </description></item>
        /// <item><description><para><c>max.message.bytes</c> specifies the maximum message size. The value must be a string. The value must be in the range of 1,048,576 to 10,485,760.</para>
        /// </description></item>
        /// <item><description><para><c>message.timestamp.type</c> specifies the message timestamp type. \<c>CreateTime\\</c> indicates the timestamp that is specified by the producer when the message is sent. If no timestamp is specified, the time when the message is created on the client is used. \<c>LogAppendTime\\</c> indicates the time when the message is stored on the server. Valid values: \<c>CreateTime\\</c> and \<c>LogAppendTime\\</c>.</para>
        /// </description></item>
        /// <item><description><para><c>message.timestamp.difference.max.ms</c> specifies the maximum allowed difference between the timestamp of the server that receives the message and the timestamp specified in the message. If \<c>message.timestamp.type\\</c> is set to \<c>CreateTime\\</c> and the time difference exceeds this threshold, <b>the message is rejected</b>. This configuration does not take effect if \<c>message.timestamp.type\\</c> is set to \<c>LogAppendTime\\</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>The following configurations are supported for reserved instances:</para>
        /// <list type="bullet">
        /// <item><description><para><c>retention.ms</c> specifies the message retention period. The value must be a string. The value must be in the range of 3,600,000 to 31,536,000,000.</para>
        /// </description></item>
        /// <item><description><para><c>max.message.bytes</c> specifies the maximum message size. The value must be a string. The value must be in the range of 1,048,576 to 10,485,760.</para>
        /// </description></item>
        /// <item><description><para><c>message.timestamp.type</c> specifies the message timestamp type. \<c>CreateTime\\</c> indicates the timestamp that is specified by the producer when the message is sent. If no timestamp is specified, the time when the message is created on the client is used. \<c>LogAppendTime\\</c> indicates the time when the message is stored on the server. Valid values: \<c>CreateTime\\</c> and \<c>LogAppendTime\\</c>.</para>
        /// </description></item>
        /// <item><description><para><c>message.timestamp.difference.max.ms</c> specifies the maximum allowed difference between the timestamp of the server that receives the message and the timestamp specified in the message. If \<c>message.timestamp.type\\</c> is set to \<c>CreateTime\\</c> and the time difference exceeds this threshold, <b>the message is rejected</b>. This configuration does not take effect if \<c>message.timestamp.type\\</c> is set to \<c>LogAppendTime\\</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600000</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}

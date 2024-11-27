// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTopicCreateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance in which you want to create the topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_188077086902****_BXSuW61e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of messages that you want to publish to the topic. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: normal messages</description></item>
        /// <item><description><b>1</b>: partitionally ordered messages</description></item>
        /// <item><description><b>2</b>: globally ordered messages</description></item>
        /// <item><description><b>4</b>: transactional messages</description></item>
        /// <item><description><b>5</b>: scheduled or delayed messages</description></item>
        /// </list>
        /// <para>For more information about message types, see <a href="https://help.aliyun.com/document_detail/155952.html">Message types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MessageType")]
        [Validation(Required=false)]
        public int? MessageType { get; set; }

        /// <summary>
        /// <para>The description of the topic that you want to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The name of the topic that you want to create. The name must meet the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 3 to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The topic name cannot start with CID or GID because CID and GID are reserved prefixes for group IDs.</description></item>
        /// <item><description>If the ApsaraMQ for RocketMQ instance in which you want to create the topic uses a namespace, the topic name must be unique in the instance. The topic name cannot be the same as an existing topic name or a group ID in the instance. The topic name can be the same as a topic name or a group ID in another instance that uses a different namespace. For example, if Instance A and Instance B use different namespaces, a topic name in Instance A can be the same as a topic name or a group ID in Instance B.</description></item>
        /// <item><description>If the instance in which you want to create the topic does not use a namespace, the topic name must be globally unique across instances and regions. The topic name cannot be the same as an existing topic name or group ID in all ApsaraMQ for RocketMQ instances that belong to your Alibaba Cloud account.</description></item>
        /// </list>
        /// <remarks>
        /// <para>To check whether an instance uses a namespace, log on to the ApsaraMQ for RocketMQ console, go to the <b>Instance Details</b> page, and then view the value of the Namespace field in the <b>Basic Information</b> section.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

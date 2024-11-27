// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsGroupCreateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the consumer group that you want to create. The group ID must meet the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The group ID must be 2 to 64 characters in length and can contain only letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>If the ApsaraMQ for RocketMQ instance in which you want to create the consumer group uses a namespace, the group ID must be unique in the instance. The group ID cannot be the same as an existing group ID or a topic name in the instance. The group ID can be the same as a group ID or a topic name in another instance that uses a different namespace. For example, if Instance A and Instance B use different namespaces, a group ID in Instance A can be the same as a group ID or a topic name in Instance B.</description></item>
        /// <item><description>If the instance does not use a namespace, the group ID must be globally unique across instances and regions. The group ID cannot be the same as an existing group ID or topic name in ApsaraMQ for RocketMQ instances that belong to your Alibaba Cloud account.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>After the consumer group is created, the group ID cannot be changed.</para>
        /// </description></item>
        /// <item><description><para>To check whether an instance uses a namespace, log on to the ApsaraMQ for RocketMQ console, go to the <b>Instance Details</b> page, and then view the value of the Namespace field in the <b>Basic Information</b> section.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_test_groupId</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The protocol over which clients in the consumer group communicate with the ApsaraMQ for RocketMQ broker. All clients in a consumer group communicate with the ApsaraMQ for RocketMQ broker over the same protocol. You must create different groups for TCP clients and HTTP clients. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b>: Clients in the consumer group consume messages over TCP. This is the default value.</description></item>
        /// <item><description><b>http</b>: Clients in the consumer group consume messages over HTTP.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The ID of the instance in which you want to create the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The description of the consumer group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}

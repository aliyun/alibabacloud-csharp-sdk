// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessagePushRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the consumer client. You can call the <a href="https://help.aliyun.com/document_detail/29598.html">OnsConsumerGetConnection</a> operation to query client IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30.5.121.**@24813#-1999745829#-1737591554#453111174894656</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <para>The ID of the consumer group. For information about what a consumer group is, see <a href="https://help.aliyun.com/document_detail/29533.html">Terms</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_test_group_id</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RocketMQ instance to which the specified consumer group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_111111111111_DOxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0BC1669963053CF68F733BB70396****</para>
        /// </summary>
        [NameInMap("MsgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

        /// <summary>
        /// <para>The topic to which the message is pushed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-mq_topic</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraMQ for RocketMQ Instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_184681981******_BXig0x6A</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the message that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E0578FE110F18B4AAC235C0******</para>
        /// </summary>
        [NameInMap("MsgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

        /// <summary>
        /// <para>The name of the topic in which the message you want to query is stored.</para>
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

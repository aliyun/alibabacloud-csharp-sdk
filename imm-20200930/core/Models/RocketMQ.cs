// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class RocketMQ : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraMQ for RocketMQ instance. If you want to use ApsaraMQ for RocketMQ for notifications, you must specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MQ_INST_11111111111_BYcNy2Nc</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the topic in ApsaraMQ for RocketMQ. If you want to use ApsaraMQ for RocketMQ for notifications, you must specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic1</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}

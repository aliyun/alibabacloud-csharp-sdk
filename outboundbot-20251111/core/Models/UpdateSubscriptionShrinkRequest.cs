// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class UpdateSubscriptionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-h964u01wh12.cn-hangzhou.rmq.aliyuncs.com:8080</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The list of subscription items.</para>
        /// </summary>
        [NameInMap("EventSubscriptions")]
        [Validation(Required=false)]
        public string EventSubscriptionsShrink { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance ID of the message queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-3g84vpf3712</para>
        /// </summary>
        [NameInMap("MqInstanceId")]
        [Validation(Required=false)]
        public string MqInstanceId { get; set; }

        /// <summary>
        /// <para>The MSMQ type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROCKET_MQ_4</para>
        /// </summary>
        [NameInMap("MqType")]
        [Validation(Required=false)]
        public string MqType { get; set; }

        /// <summary>
        /// <para>The password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa44w0rd</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The producer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GID_123456</para>
        /// </summary>
        [NameInMap("ProducerId")]
        [Validation(Required=false)]
        public string ProducerId { get; set; }

        /// <summary>
        /// <para>The topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OUTBOUND_BOT_TOPIC</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}

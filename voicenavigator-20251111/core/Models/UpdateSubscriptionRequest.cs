// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class UpdateSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint. This parameter is required when ROCKET_MQ_4 or ROCKET_MQ_5 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-l4p89zajz67.cn-hangzhou.rmq.aliyuncs.com:8080</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The list of subscribed events.</para>
        /// </summary>
        [NameInMap("EventSubscriptions")]
        [Validation(Required=false)]
        public List<string> EventSubscriptions { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The MQ instance ID. This parameter is required when ROCKET_MQ_5 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-l4p89zajz67.cn</para>
        /// </summary>
        [NameInMap("MqInstanceId")]
        [Validation(Required=false)]
        public string MqInstanceId { get; set; }

        /// <summary>
        /// <para>The message push type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROCKET_MQ_4</para>
        /// </summary>
        [NameInMap("MqType")]
        [Validation(Required=false)]
        public string MqType { get; set; }

        /// <summary>
        /// <para>The password. This parameter is required when ROCKET_MQ_5 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pwd</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The producer ID. This parameter is required when ROCKET_MQ_4 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("ProducerId")]
        [Validation(Required=false)]
        public string ProducerId { get; set; }

        /// <summary>
        /// <para>The queue topic. This parameter is required when ROCKET_MQ_4 or ROCKET_MQ_5 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The username. This parameter is required when ROCKET_MQ_5 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}

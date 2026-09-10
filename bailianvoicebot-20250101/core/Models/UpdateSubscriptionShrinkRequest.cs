// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class UpdateSubscriptionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Model Studio business space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-c11iig67g863rih8</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// <para>The endpoint. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_4</c> or <c>ROCKET_MQ_5</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-l4p89zajz67.cn-hangzhou.rmq.aliyuncs.com:8080</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>A list of events to subscribe to.</para>
        /// </summary>
        [NameInMap("EventSubscriptions")]
        [Validation(Required=false)]
        public string EventSubscriptionsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RocketMQ instance. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_5</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-l4p89zajz67.cn</para>
        /// </summary>
        [NameInMap("MqInstanceId")]
        [Validation(Required=false)]
        public string MqInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the message queue service. Valid values are <c>ROCKET_MQ_4</c> and <c>ROCKET_MQ_5</c>, which correspond to ApsaraMQ for RocketMQ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROCKET_MQ_4</para>
        /// </summary>
        [NameInMap("MqType")]
        [Validation(Required=false)]
        public string MqType { get; set; }

        /// <summary>
        /// <para>The password for authentication. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_5</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pwd</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The ID of the producer. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_4</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("ProducerId")]
        [Validation(Required=false)]
        public string ProducerId { get; set; }

        /// <summary>
        /// <para>The topic of the queue. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_4</c> or <c>ROCKET_MQ_5</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        /// <summary>
        /// <para>The username for authentication. This parameter is required if <c>MqType</c> is set to <c>ROCKET_MQ_5</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}

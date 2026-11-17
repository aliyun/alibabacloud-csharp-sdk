// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class TriggerChatFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The time when the event is declared to occur, which is the time when the flow is triggered. This is generally the time when the request is constructed. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731502129000</para>
        /// </summary>
        [NameInMap("ClaimTimeMillis")]
        [Validation(Required=false)]
        public long? ClaimTimeMillis { get; set; }

        /// <summary>
        /// <para>The input parameters in key-value format. The keys must match the input parameter policy that you configured for the start node of the flow. To view the variable names of the start node, click the name of the flow with a manual trigger in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> console to go to the canvas orchestration page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;my_biz_data_0&quot;: &quot;hi&quot;,
        ///   &quot;my_biz_data_1&quot;: &quot;1024&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string DataShrink { get; set; }

        /// <summary>
        /// <para>The time when the event is declared to be discarded, which is the expiration time for triggering the flow. If this field is specified and the response time after the request is initiated exceeds this time, the flow trigger is canceled. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731502729000</para>
        /// </summary>
        [NameInMap("DiscardTimeMillis")]
        [Validation(Required=false)]
        public long? DiscardTimeMillis { get; set; }

        /// <summary>
        /// <para>The flow code. You can view the flow code in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>The custom serial number of the external system. This parameter is used to associate the serial number of the external business system. After the flow is triggered, you can obtain this parameter in the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8d4acf7e-e360-eb83-6d74-fcf9c4538fda</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The custom unique ID of the event. This parameter is used to ensure idempotence for the trigger. Do not include any business semantics in this parameter. After the flow is triggered, you can obtain this parameter in the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c68622e6-5f0d-c8a4-af41-e949c2a7580e</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}

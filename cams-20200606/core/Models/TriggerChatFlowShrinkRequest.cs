// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class TriggerChatFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The time when the event occurs. This is when the flow is triggered and is typically the time when the request is created. This is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731502129000</para>
        /// </summary>
        [NameInMap("ClaimTimeMillis")]
        [Validation(Required=false)]
        public long? ClaimTimeMillis { get; set; }

        /// <summary>
        /// <para>The input parameters in a key-value format. The keys must match the input parameter policy configured in the start node of the flow. To view the variable names in the start node, go to the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a>, click the name of the flow, and open the orchestration canvas.</para>
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
        /// <para>The time when the event expires. If you specify this parameter, the trigger is canceled if the request is not processed before this time. This is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731502729000</para>
        /// </summary>
        [NameInMap("DiscardTimeMillis")]
        [Validation(Required=false)]
        public long? DiscardTimeMillis { get; set; }

        /// <summary>
        /// <para>The code of the flow. View the flow code on the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>A custom serial number from an external system. Use this parameter to associate the trigger with an external business process. After the flow is triggered, you can retrieve this parameter from within the flow.</para>
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
        /// <para>A custom unique ID for the event, used to ensure idempotence. Do not include business semantics in the ID. After the flow is triggered, you can retrieve this parameter from within the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c68622e6-5f0d-c8a4-af41-e949c2a7580e</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}

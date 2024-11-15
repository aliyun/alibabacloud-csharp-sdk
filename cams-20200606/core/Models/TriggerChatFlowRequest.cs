// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class TriggerChatFlowRequest : TeaModel {
        /// <summary>
        /// <para>The declared occurrence time of the event, usually the time when the request was constructed, in milliseconds timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731502129000</para>
        /// </summary>
        [NameInMap("ClaimTimeMillis")]
        [Validation(Required=false)]
        public long? ClaimTimeMillis { get; set; }

        /// <summary>
        /// <para>Input parameters in Key-Value format. The Key must match the input strategy configured at the start node of your flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;my_biz_data_0&quot;: &quot;hi&quot;, &quot;my_biz_data_1&quot;: &quot;1024&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>The time when the event should be discarded, i.e., the expiration time. If this field is specified, the message will be discarded if it exceeds this time, in milliseconds timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731502729000</para>
        /// </summary>
        [NameInMap("DiscardTimeMillis")]
        [Validation(Required=false)]
        public long? DiscardTimeMillis { get; set; }

        /// <summary>
        /// <para>Flow code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4912c16943b4dfba44bd6fedacf8c70</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>External system transaction number, used to associate with external business system transactions. You can retrieve this parameter within the flow after triggering.</para>
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
        /// <para>Unique event ID used for idempotent triggers. Do not include any business semantics; you can retrieve this parameter within the flow after triggering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c68622e6-5f0d-c8a4-af41-e949c2a7580e</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}

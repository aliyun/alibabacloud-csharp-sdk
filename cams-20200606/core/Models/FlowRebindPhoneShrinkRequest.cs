// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class FlowRebindPhoneShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The message channel code, which is the channel ID. You can view the channel ID on the <a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8c8*********</para>
        /// </summary>
        [NameInMap("ChannelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// <para>The message channel type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>INSTAGRAM</para>
        /// </description></item>
        /// <item><description><para>WHATSAPP</para>
        /// </description></item>
        /// <item><description><para>MESSENGER</para>
        /// </description></item>
        /// </list>
        /// <para>&lt;props=&quot;intl&quot;&gt;- VIBER</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The flow code. You can view it in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>The flow version. You can view the flow version by clicking the flow name in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> to go to the canvas page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public string FlowVersion { get; set; }

        /// <summary>
        /// <para>The multi-WABA binding.</para>
        /// </summary>
        [NameInMap("MultiWabaPhoneNumbers")]
        [Validation(Required=false)]
        public string MultiWabaPhoneNumbersShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The list of phone numbers, PageIds, AccountIds&lt;props=&quot;intl&quot;&gt;, or ServiceIds under the channel instance.</para>
        /// </summary>
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public string PhoneNumbersShrink { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The WABA account ID, PageId, AccountId&lt;props=&quot;intl&quot;&gt;, or ServiceId.</para>
        /// <list type="bullet">
        /// <item><description><para>When the ChannelType parameter is set to WHATSAPP, specify the WABA account ID. You can view the WABA account ID on the Channel Management &gt; Management &gt; WABA Management page.</para>
        /// </description></item>
        /// <item><description><para>When the ChannelType parameter is not set to WHATSAPP, specify the PageId for MESSENGER, the AccountId for INSTAGRAM&lt;props=&quot;intl&quot;&gt;, or the ServiceId for VIBER.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1952************</para>
        /// </summary>
        [NameInMap("WabaId")]
        [Validation(Required=false)]
        public string WabaId { get; set; }

    }

}

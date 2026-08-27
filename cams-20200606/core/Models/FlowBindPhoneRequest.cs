// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class FlowBindPhoneRequest : TeaModel {
        /// <summary>
        /// <para>The message channel code, which is the channel ID. View the channel ID in the <a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a> page.</para>
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
        /// <item><description>INSTAGRAM</description></item>
        /// <item><description>WHATSAPP</description></item>
        /// <item><description>MESSENGER</description></item>
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
        /// <para>The flow code. View the flow code in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Builder</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>The flow version. Click the flow name in the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Builder</a> page to enter the flow builder canvas and view the flow version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public string FlowVersion { get; set; }

        /// <summary>
        /// <para>The multi-WABA binding configuration.</para>
        /// </summary>
        [NameInMap("MultiWabaPhoneNumbers")]
        [Validation(Required=false)]
        public List<FlowBindPhoneRequestMultiWabaPhoneNumbers> MultiWabaPhoneNumbers { get; set; }
        public class FlowBindPhoneRequestMultiWabaPhoneNumbers : TeaModel {
            /// <summary>
            /// <para>The channel code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("ChannelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            /// <summary>
            /// <para>The list of phone numbers.</para>
            /// </summary>
            [NameInMap("PhoneNumbers")]
            [Validation(Required=false)]
            public List<string> PhoneNumbers { get; set; }

            /// <summary>
            /// <para>wabaId</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("WabaId")]
            [Validation(Required=false)]
            public string WabaId { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The list of phone numbers, PageIds, or AccountIds&lt;props=&quot;intl&quot;&gt;, or ServiceIds under the channel instance.</para>
        /// </summary>
        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public List<string> PhoneNumbers { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The WABA account ID, PageId, or AccountId&lt;props=&quot;intl&quot;&gt;, or ServiceId.</para>
        /// <list type="bullet">
        /// <item><description><para>If the ChannelType parameter is set to WHATSAPP, specify the WABA account ID. View the WABA account ID in <a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a> &gt; <b>Manage</b> &gt; <b>WABA Management</b>.</para>
        /// </description></item>
        /// <item><description><para>If the ChannelType parameter is not set to WHATSAPP, specify the PageId for MESSENGER, the AccountId for INSTAGRAM&lt;props=&quot;intl&quot;&gt;, or the ServiceId for VIBER.</para>
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

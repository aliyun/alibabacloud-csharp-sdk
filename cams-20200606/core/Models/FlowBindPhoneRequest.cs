// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class FlowBindPhoneRequest : TeaModel {
        /// <summary>
        /// <para>The message channel code. This is the channel ID. View the channel ID on the <a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a> page.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <list type="bullet">
        /// <item><description>VIBER</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The flow code. View the flow code on the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ccc41**************************</para>
        /// </summary>
        [NameInMap("FlowCode")]
        [Validation(Required=false)]
        public string FlowCode { get; set; }

        /// <summary>
        /// <para>The flow version. On the <a href="https://chatapp.console.aliyun.com/ChatFlowBuilder">Flow Editor</a> page, click the flow name to go to the flow editor canvas and view the flow version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FlowVersion")]
        [Validation(Required=false)]
        public string FlowVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>A list of phone numbers, PageIds, AccountIds&lt;props=&quot;intl&quot;&gt;, or ServiceIds for the channel instance.</para>
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
        /// <para>The WABA account ID, PageId, AccountId&lt;props=&quot;intl&quot;&gt;, or ServiceId.</para>
        /// <list type="bullet">
        /// <item><description><para>If \<c>ChannelType\\</c> is \<c>WHATSAPP\\</c>, pass the WABA account ID. View the WABA account ID on the <b>WABA Management</b> page by navigating to <b>Channel Management</b> &gt; <b>Manage</b>.</para>
        /// </description></item>
        /// <item><description><para>If \<c>ChannelType\\</c> is not \<c>WHATSAPP\\</c>, pass the PageId for \<c>MESSENGER\\</c> or the AccountId for \<c>INSTAGRAM\\</c>&lt;props=&quot;intl&quot;&gt;. For \<c>VIBER\\</c>, pass the ServiceId.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1952************</para>
        /// </summary>
        [NameInMap("WabaId")]
        [Validation(Required=false)]
        public string WabaId { get; set; }

    }

}

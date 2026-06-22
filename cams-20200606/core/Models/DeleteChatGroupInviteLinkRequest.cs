// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class DeleteChatGroupInviteLinkRequest : TeaModel {
        /// <summary>
        /// <para>The business number. Call the <a href="https://help.aliyun.com/document_detail/2932629.html">ListChatGroup</a> operation to obtain the business number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8613800***</para>
        /// </summary>
        [NameInMap("BusinessNumber")]
        [Validation(Required=false)]
        public string BusinessNumber { get; set; }

        /// <summary>
        /// <para>The channel type. Set this parameter to the following value:</para>
        /// <list type="bullet">
        /// <item><description><b>WHATSAPP</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only the WhatsApp channel is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The space ID or instance ID for an ISV\&quot;s sub-customer. This ID also serves as the channel ID. You can find this ID on the <a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-8***</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The group ID. Call the <a href="https://help.aliyun.com/document_detail/2932629.html">ListChatGroup</a> operation to obtain the group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E398****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

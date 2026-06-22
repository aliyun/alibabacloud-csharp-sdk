// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class AddChatGroupInviteLinkRequest : TeaModel {
        /// <summary>
        /// <para>The business phone number. To obtain this number, call the <a href="https://help.aliyun.com/document_detail/2932629.html">ListChatGroup</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8613800***</para>
        /// </summary>
        [NameInMap("BusinessNumber")]
        [Validation(Required=false)]
        public string BusinessNumber { get; set; }

        /// <summary>
        /// <para>The type. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>WHATSAPP</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Currently, only the WhatsApp channel type is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WHATSAPP</para>
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>The SpaceId or instance ID of the ISV sub-customer. This is the channel ID. View the channel ID on the <a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-x***</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The group ID. To obtain this ID, call the <a href="https://help.aliyun.com/document_detail/2932629.html">ListChatGroup</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E93kdk****</para>
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateChatGroupRequest : TeaModel {
        /// <summary>
        /// <para>The business number. To view the business numbers, call the <a href="https://help.aliyun.com/document_detail/2932629.html">ListChatGroup</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8613800***</para>
        /// </summary>
        [NameInMap("BusinessNumber")]
        [Validation(Required=false)]
        public string BusinessNumber { get; set; }

        /// <summary>
        /// <para>The channel type. Valid value:</para>
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
        /// <para>The Space ID of the ISV sub-customer, or the instance ID of the direct customer. View the Space ID on the</para>
        /// <para>&lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList">Channel Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-***</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The group description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The group ID. To view the group IDs, call the <a href="https://help.aliyun.com/document_detail/2932629.html">ListChatGroup</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA303***</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The group profile picture.</para>
        /// <remarks>
        /// <para>Image requirements</para>
        /// <list type="bullet">
        /// <item><description><para>Supported MIME type: image/jpeg.</para>
        /// </description></item>
        /// <item><description><para>Maximum file size: 5 MB.</para>
        /// </description></item>
        /// <item><description><para>The image must be square. Minimum dimensions: 192x192 pixels.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("ProfilePictureFile")]
        [Validation(Required=false)]
        public string ProfilePictureFile { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The group title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test title.</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}

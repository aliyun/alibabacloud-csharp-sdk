// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatGroupRequest : TeaModel {
        /// <summary>
        /// <para>The business number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8613800***</para>
        /// </summary>
        [NameInMap("BusinessNumber")]
        [Validation(Required=false)]
        public string BusinessNumber { get; set; }

        /// <summary>
        /// <para>The channel type. Valid value: <b>WHATSAPP</b>.</para>
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
        /// <para>The instance ID (or SpaceId) of an ISV sub-customer, which also serves as the channel ID. You can find it on the <a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-x***</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The Telegram group link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("GroupLink")]
        [Validation(Required=false)]
        public string GroupLink { get; set; }

        /// <summary>
        /// <para>The group status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ACTIVE: In use.</para>
        /// </description></item>
        /// <item><description><para>INACTIVE: Not activated.</para>
        /// </description></item>
        /// <item><description><para>SUSPENDED: Suspended.</para>
        /// </description></item>
        /// <item><description><para>CREATING: Being created.</para>
        /// </description></item>
        /// <item><description><para>DELETING: Being deleted.</para>
        /// </description></item>
        /// <item><description><para>UPDATING: Being updated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("GroupStatus")]
        [Validation(Required=false)]
        public string GroupStatus { get; set; }

        /// <summary>
        /// <para>The Telegram group type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The paging information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListChatGroupRequestPage Page { get; set; }
        public class ListChatGroupRequestPage : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

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
        /// <para>test</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

    }

}

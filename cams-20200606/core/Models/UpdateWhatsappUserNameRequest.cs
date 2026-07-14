// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateWhatsappUserNameRequest : TeaModel {
        /// <summary>
        /// <para>The space ID of the ISV sub-customer or the instance ID of the direct customer. You can view the space ID on the
        /// &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList">Channel Management</a>
        /// page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-kskd****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The business phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8613800***</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The transfer action that controls what happens when the requested username is currently used by another business phone number in the same business asset portfolio. For example, use this parameter when you want to move an existing username to another phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>none (default): does not transfer the account. If another business phone number in the same business asset portfolio already uses this username, the request fails with error code 147005.</para>
        /// </description></item>
        /// <item><description><para>force_transfer: transfers the account from the other business phone number to this business phone number. The account is removed from the other phone number and assigned to this phone number.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("TransferAction")]
        [Validation(Required=false)]
        public string TransferAction { get; set; }

        /// <summary>
        /// <para>Whatsapp user name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}

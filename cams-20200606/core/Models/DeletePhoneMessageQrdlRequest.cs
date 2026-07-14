// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class DeletePhoneMessageQrdlRequest : TeaModel {
        /// <summary>
        /// <para>The space ID of the ISV sub-customer or the instance ID of the direct customer. You can view the Space ID on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList">Channel Management</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-kei****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The phone number. You can view the phone number on the &lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement"><b>Channel Management</b></a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList">Channel Management</a> &gt; <b>Management</b> &gt; <b>WABA Management</b> &gt; <b>Number Management</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86158********</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The QR code encoding. This is the QrdlCode returned by the <a href="https://help.aliyun.com/document_detail/2638749.html">CreatePhoneMessageQrdl</a> operation when you created the message QR code, or the QrdlCode returned by the <a href="https://help.aliyun.com/document_detail/2638746.html">UpdatePhoneMessageQrdl</a> operation when you updated the QR code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9II3***</para>
        /// </summary>
        [NameInMap("QrdlCode")]
        [Validation(Required=false)]
        public string QrdlCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

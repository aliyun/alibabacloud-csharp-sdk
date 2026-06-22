// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class WhatsappCallShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86138***</para>
        /// </summary>
        [NameInMap("BusinessNumber")]
        [Validation(Required=false)]
        public string BusinessNumber { get; set; }

        /// <summary>
        /// <para>The action to perform on the call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connect</para>
        /// </summary>
        [NameInMap("CallAction")]
        [Validation(Required=false)]
        public string CallAction { get; set; }

        /// <summary>
        /// <para>The call ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wamid-xx**</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The Space ID of the ISV sub-customer, or the instance ID of the direct customer. View the Space ID on the</para>
        /// <para>&lt;props=&quot;china&quot;&gt;<a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a>&lt;props=&quot;intl&quot;&gt;<a href="https://chatapp.console.alibabacloud.com/CustomerList">Channel Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-xx**</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

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
        /// <para>The call negotiation information.</para>
        /// </summary>
        [NameInMap("Session")]
        [Validation(Required=false)]
        public string SessionShrink { get; set; }

        /// <summary>
        /// <para>The user\&quot;s number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86131***</para>
        /// </summary>
        [NameInMap("UserNumber")]
        [Validation(Required=false)]
        public string UserNumber { get; set; }

    }

}

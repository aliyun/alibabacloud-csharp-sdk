// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ModifyMailAddressRequest : TeaModel {
        /// <summary>
        /// <para>Sending address ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1344565</para>
        /// </summary>
        [NameInMap("MailAddressId")]
        [Validation(Required=false)]
        public int? MailAddressId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>Length should be 10 to 20 characters, and must include numbers, uppercase letters, and lowercase letters.</para>
        /// </description></item>
        /// <item><description><para>Must contain at least 2 digits, 2 uppercase letters, and 2 lowercase letters, and neither the digits nor the letters can consist of a single character repeated.</para>
        /// </description></item>
        /// <item><description><para>Cannot be the same as the last set password.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DM1mail1234</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Reply address</para>
        /// 
        /// <b>Example:</b>
        /// <para>a***@example.net</para>
        /// </summary>
        [NameInMap("ReplyAddress")]
        [Validation(Required=false)]
        public string ReplyAddress { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

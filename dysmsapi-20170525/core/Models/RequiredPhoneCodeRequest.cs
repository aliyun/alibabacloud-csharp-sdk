// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class RequiredPhoneCodeRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The administrator\&quot;s phone number that receives the verification code.</para>
        /// <list type="bullet">
        /// <item><description>The account that <b>calls this operation to send the verification code must be the same account that submits the qualification</b>. Otherwise, the call fails.</description></item>
        /// <item><description>Phone number format: +/+86/0086/86 or a mobile phone number without any prefix, for example 1390000****.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137****1234</para>
        /// </summary>
        [NameInMap("PhoneNo")]
        [Validation(Required=false)]
        public string PhoneNo { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

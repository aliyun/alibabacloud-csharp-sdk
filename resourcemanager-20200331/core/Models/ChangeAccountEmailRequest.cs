// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ChangeAccountEmailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>181761095690****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The email address of the member.</para>
        /// <remarks>
        /// <para>The system automatically sends a verification email to the specified email address. The modification takes effect only after the email address is verified. After the verification, the system synchronously updates the email address and security email address of the account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

    }

}

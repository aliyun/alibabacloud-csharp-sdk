// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ResetAccountPasswordResponseBody : TeaModel {
        /// <summary>
        /// <para>The new password for the account. The password must be 8 to 32 characters in length and contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include <c>! @ # $ % ^ &amp; * ( ) _ + - =</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>187C80FC-75C4-477C-BBF2-A368A36D041C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

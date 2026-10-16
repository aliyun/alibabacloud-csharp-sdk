// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class SendVerificationCodeForBindSecureMobilePhoneResponseBody : TeaModel {
        /// <summary>
        /// <para>The expiration time of the verification code. The time is in RFC 3339 UTC format, indicated by Z for UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-17T07:38:41.747Z</para>
        /// </summary>
        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DCD43660-75DD-5D15-B342-1B83FCA5B913</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

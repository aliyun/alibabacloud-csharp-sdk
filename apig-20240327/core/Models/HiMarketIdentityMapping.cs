// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketIdentityMapping : TeaModel {
        /// <summary>
        /// <para>The identity provider attribute that maps to the user\&quot;s email address.</para>
        /// </summary>
        [NameInMap("emailField")]
        [Validation(Required=false)]
        public string EmailField { get; set; }

        /// <summary>
        /// <para>The identity provider attribute that maps to the user\&quot;s unique ID.</para>
        /// </summary>
        [NameInMap("userIdField")]
        [Validation(Required=false)]
        public string UserIdField { get; set; }

        /// <summary>
        /// <para>The identity provider attribute that maps to the username.</para>
        /// </summary>
        [NameInMap("userNameField")]
        [Validation(Required=false)]
        public string UserNameField { get; set; }

    }

}

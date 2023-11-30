// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetShareLinkTokenResponseBody : TeaModel {
        /// <summary>
        /// The validity period of the token. Unit: seconds. For example, a value of 7200 indicates two hours.
        /// </summary>
        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// The JSON Web Token (JWT).
        /// </summary>
        [NameInMap("share_token")]
        [Validation(Required=false)]
        public string ShareToken { get; set; }

    }

}

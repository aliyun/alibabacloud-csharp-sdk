// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CreateAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// The value of the activation code. The value is returned only once after the CreateAccessToken operation is called and cannot be subsequently queried. Make sure that you properly save the returned value.
        /// </summary>
        [NameInMap("AccessTokenCode")]
        [Validation(Required=false)]
        public string AccessTokenCode { get; set; }

        /// <summary>
        /// The ID of the activation code.
        /// </summary>
        [NameInMap("AccessTokenId")]
        [Validation(Required=false)]
        public string AccessTokenId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

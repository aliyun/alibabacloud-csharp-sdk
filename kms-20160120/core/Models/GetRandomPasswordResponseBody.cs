// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetRandomPasswordResponseBody : TeaModel {
        /// <summary>
        /// The generated random password.
        /// </summary>
        [NameInMap("RandomPassword")]
        [Validation(Required=false)]
        public string RandomPassword { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

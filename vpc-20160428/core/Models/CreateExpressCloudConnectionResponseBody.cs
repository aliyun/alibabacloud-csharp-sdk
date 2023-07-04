// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressCloudConnectionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the ECC instance.
        /// </summary>
        [NameInMap("EccId")]
        [Validation(Required=false)]
        public string EccId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

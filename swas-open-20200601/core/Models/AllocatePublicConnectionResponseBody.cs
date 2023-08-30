// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class AllocatePublicConnectionResponseBody : TeaModel {
        /// <summary>
        /// The public endpoint that is assigned to the Simple Database Service instance.
        /// </summary>
        [NameInMap("PublicConnection")]
        [Validation(Required=false)]
        public string PublicConnection { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

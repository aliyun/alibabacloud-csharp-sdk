// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetInvalidDomainCountResponseBody : TeaModel {
        /// <summary>
        /// The number of invalid domain names.
        /// </summary>
        [NameInMap("InvalidDomainCount")]
        [Validation(Required=false)]
        public string InvalidDomainCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

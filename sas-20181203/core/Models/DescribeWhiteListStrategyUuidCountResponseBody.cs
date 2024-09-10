// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListStrategyUuidCountResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of the servers on which the application whitelist policy takes effect.
        /// </summary>
        [NameInMap("UuidCount")]
        [Validation(Required=false)]
        public int? UuidCount { get; set; }

    }

}

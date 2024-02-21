// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DataSessionStatClientStatsValue : TeaModel {
        /// <summary>
        /// The number of clients whose IP addresses are active.
        /// </summary>
        [NameInMap("ActiveCount")]
        [Validation(Required=false)]
        public long? ActiveCount { get; set; }

        /// <summary>
        /// The total number of IP addresses of clients.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

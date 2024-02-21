// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DataSessionStatDbStatsValue : TeaModel {
        /// <summary>
        /// The number of active namespaces.
        /// </summary>
        [NameInMap("ActiveCount")]
        [Validation(Required=false)]
        public long? ActiveCount { get; set; }

        /// <summary>
        /// The total number of namespaces.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListShipperResponseBody : TeaModel {
        /// <summary>
        /// The number of log shipping jobs returned.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The names of the log shipping jobs.
        /// </summary>
        [NameInMap("shipper")]
        [Validation(Required=false)]
        public List<string> Shipper { get; set; }

        /// <summary>
        /// The total number of log shipping jobs.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

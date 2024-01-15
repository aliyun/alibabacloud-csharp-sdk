// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListConfigResponseBody : TeaModel {
        /// <summary>
        /// The Logtail configurations that are returned on the current page.
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<string> Configs { get; set; }

        /// <summary>
        /// The number of Logtail configurations that are returned on the current page.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The total number of Logtail configurations that meet the query conditions.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListDomainsResponseBody : TeaModel {
        /// <summary>
        /// The number of domain names that are returned on the current page.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// The domain names.
        /// </summary>
        [NameInMap("domains")]
        [Validation(Required=false)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// The total number of domain names that are returned.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}

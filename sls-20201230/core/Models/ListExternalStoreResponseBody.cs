// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListExternalStoreResponseBody : TeaModel {
        /// <summary>
        /// The number of external stores returned on the current page.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The names of the external stores.
        /// </summary>
        [NameInMap("externalstores")]
        [Validation(Required=false)]
        public List<ExternalStore> Externalstores { get; set; }

        /// <summary>
        /// The number of external stores that meet the query conditions.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

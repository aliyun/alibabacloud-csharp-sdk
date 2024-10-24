// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListStoreViewsResponseBody : TeaModel {
        /// <summary>
        /// The number of returned datasets.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The dataset names.
        /// </summary>
        [NameInMap("storeviews")]
        [Validation(Required=false)]
        public List<string> Storeviews { get; set; }

        /// <summary>
        /// The total number of datasets in the project.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

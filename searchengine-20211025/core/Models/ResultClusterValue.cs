// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ResultClusterValue : TeaModel {
        /// <summary>
        /// The maximum number of full indexes that can be concurrently built.
        /// </summary>
        [NameInMap("buildParallelNum")]
        [Validation(Required=false)]
        public int? BuildParallelNum { get; set; }

        /// <summary>
        /// The maximum number of full indexes that can be concurrently merged.
        /// </summary>
        [NameInMap("mergeParallelNum")]
        [Validation(Required=false)]
        public int? MergeParallelNum { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListSavedSearchResponseBody : TeaModel {
        /// <summary>
        /// The number of saved searches returned on the current page.
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The saved searches.
        /// </summary>
        [NameInMap("savedsearchItems")]
        [Validation(Required=false)]
        public List<SavedSearch> SavedsearchItems { get; set; }

        /// <summary>
        /// The total number of saved searches that meet the query conditions.
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

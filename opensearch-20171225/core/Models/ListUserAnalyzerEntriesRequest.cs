// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListUserAnalyzerEntriesRequest : TeaModel {
        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The key to be used to query entries.
        /// </summary>
        [NameInMap("word")]
        [Validation(Required=false)]
        public string Word { get; set; }

    }

}

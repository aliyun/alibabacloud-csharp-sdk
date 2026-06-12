// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListAzureBlobIngestionResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of tasks returned on the current page.</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>A list of Azure Blob ingestion tasks.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<AzureBlobIngestion> Results { get; set; }

        /// <summary>
        /// <para>The total number of tasks that match the query.</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}

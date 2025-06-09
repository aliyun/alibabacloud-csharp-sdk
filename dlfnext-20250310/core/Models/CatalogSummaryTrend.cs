// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CatalogSummaryTrend : TeaModel {
        /// <summary>
        /// <para>API visit count trends</para>
        /// </summary>
        [NameInMap("apiVisitCount")]
        [Validation(Required=false)]
        public List<DateSummary> ApiVisitCount { get; set; }

        /// <summary>
        /// <para>Table count trends</para>
        /// </summary>
        [NameInMap("throughput")]
        [Validation(Required=false)]
        public List<DateSummary> Throughput { get; set; }

        /// <summary>
        /// <para>Historical total file count</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public List<DateSummary> TotalFileCount { get; set; }

        /// <summary>
        /// <para>Database count trends</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public List<DateSummary> TotalFileSizeInBytes { get; set; }

        /// <summary>
        /// <para>Latest snapshot file count</para>
        /// </summary>
        [NameInMap("totalMetaCount")]
        [Validation(Required=false)]
        public List<DateSummary> TotalMetaCount { get; set; }

    }

}

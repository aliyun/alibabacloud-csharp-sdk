// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CatalogSummaryTrend : TeaModel {
        /// <summary>
        /// <para>The trend of total metadata requests.</para>
        /// </summary>
        [NameInMap("apiVisitCount")]
        [Validation(Required=false)]
        public List<DateSummary> ApiVisitCount { get; set; }

        /// <summary>
        /// <para>The trend of file access count.</para>
        /// </summary>
        [NameInMap("fileAccessCount")]
        [Validation(Required=false)]
        public List<DateSummary> FileAccessCount { get; set; }

        /// <summary>
        /// <para>The data access traffic trend.</para>
        /// </summary>
        [NameInMap("throughput")]
        [Validation(Required=false)]
        public List<DateSummary> Throughput { get; set; }

        /// <summary>
        /// <para>The trend of total file count.</para>
        /// </summary>
        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public List<DateSummary> TotalFileCount { get; set; }

        /// <summary>
        /// <para>The trend of total storage capacity.</para>
        /// </summary>
        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public List<DateSummary> TotalFileSizeInBytes { get; set; }

        /// <summary>
        /// <para>The trend of total metadata object count.</para>
        /// </summary>
        [NameInMap("totalMetaCount")]
        [Validation(Required=false)]
        public List<DateSummary> TotalMetaCount { get; set; }

    }

}

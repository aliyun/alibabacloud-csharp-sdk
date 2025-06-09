// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CatalogSummary : TeaModel {
        [NameInMap("apiVisitCountMonthly")]
        [Validation(Required=false)]
        public long? ApiVisitCountMonthly { get; set; }

        [NameInMap("databaseCount")]
        [Validation(Required=false)]
        public MoMValues DatabaseCount { get; set; }

        /// <summary>
        /// <para>Update date of the statistics</para>
        /// </summary>
        [NameInMap("generatedDate")]
        [Validation(Required=false)]
        public string GeneratedDate { get; set; }

        [NameInMap("partitionCount")]
        [Validation(Required=false)]
        public MoMValues PartitionCount { get; set; }

        [NameInMap("tableCount")]
        [Validation(Required=false)]
        public MoMValues TableCount { get; set; }

        [NameInMap("throughputMonthly")]
        [Validation(Required=false)]
        public long? ThroughputMonthly { get; set; }

        [NameInMap("totalFileCount")]
        [Validation(Required=false)]
        public MoMValues TotalFileCount { get; set; }

        [NameInMap("totalFileSizeInBytes")]
        [Validation(Required=false)]
        public MoMValues TotalFileSizeInBytes { get; set; }

    }

}

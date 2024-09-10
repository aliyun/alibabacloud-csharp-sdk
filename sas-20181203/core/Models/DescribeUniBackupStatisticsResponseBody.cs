// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of protected database instances.
        /// </summary>
        [NameInMap("ProtectedDatabaseCount")]
        [Validation(Required=false)]
        public int? ProtectedDatabaseCount { get; set; }

        /// <summary>
        /// The regions of the database instances.
        /// </summary>
        [NameInMap("RegionCountList")]
        [Validation(Required=false)]
        public List<DescribeUniBackupStatisticsResponseBodyRegionCountList> RegionCountList { get; set; }
        public class DescribeUniBackupStatisticsResponseBodyRegionCountList : TeaModel {
            /// <summary>
            /// The number of database instances that are automatically scanned.
            /// </summary>
            [NameInMap("AutomaticCount")]
            [Validation(Required=false)]
            public string AutomaticCount { get; set; }

            /// <summary>
            /// The ID of the region in which the database instance resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of the restoration tasks that are running.
        /// </summary>
        [NameInMap("RestoringTaskCount")]
        [Validation(Required=false)]
        public int? RestoringTaskCount { get; set; }

        /// <summary>
        /// The total number of database instances that can be restored.
        /// </summary>
        [NameInMap("TotalRecoverableCount")]
        [Validation(Required=false)]
        public int? TotalRecoverableCount { get; set; }

        /// <summary>
        /// The total number of the restoration tasks.
        /// </summary>
        [NameInMap("TotalRestoreTaskCount")]
        [Validation(Required=false)]
        public int? TotalRestoreTaskCount { get; set; }

        /// <summary>
        /// The number of unprotected database instances.
        /// </summary>
        [NameInMap("UnprotectedDatabaseCount")]
        [Validation(Required=false)]
        public int? UnprotectedDatabaseCount { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupPlansRequest : TeaModel {
        /// <summary>
        /// The filter.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeBackupPlansRequestFilters> Filters { get; set; }
        public class DescribeBackupPlansRequestFilters : TeaModel {
            /// <summary>
            /// The keys in the filter. Valid values:
            /// 
            /// *   **regionId**: the ID of a region
            /// *   **planId**: the ID of a backup plan
            /// *   **sourceType**: the type of a data source
            /// *   **vaultId**: the ID of a backup vault
            /// *   **instanceName**: the name of an instance
            /// *   **instanceId**: the ID of an instance
            /// *   **planName**: the name of a backup plan
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The values that you want to match in the filter.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **ECS_FILE**: Elastic Compute Service (ECS) files
        /// *   **OSS**: Object Storage Service (OSS) buckets
        /// *   **NAS**: Apsara File Storage NAS file systems
        /// *   **OTS**: Tablestore instances
        /// *   **UDM_ECS**: ECS instances
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}

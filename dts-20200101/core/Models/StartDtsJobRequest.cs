// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class StartDtsJobRequest : TeaModel {
        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking instance.
        /// 
        /// >  You can call the [DescribeMigrationJobs](~~208139~~), [DescribeSubscriptionInstances](~~49442~~), or [DescribeSynchronizationJobs](~~49454~~) operation to query the instance ID
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking task.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The region ID of the Data Transmission Service (DTS) instance. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The synchronization direction. Default value: Forward. Valid values:
        /// 
        /// *   **Forward**: Data is synchronized from the source database to the destination database.
        /// 
        /// *   **Reverse**: Data is synchronized from the destination database to the source database.
        /// 
        /// >You can set this parameter to **Reverse** to start the reverse synchronization task only if the topology is two-way synchronization.
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

    }

}

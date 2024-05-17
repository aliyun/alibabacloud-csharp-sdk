/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class BatchDeleteJobsRequest : TeaModel {
        /// <summary>
        /// The ID of the application. You can obtain the application ID on the **Application Management** page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The job IDs. Separate multiple job IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobIdList")]
        [Validation(Required=false)]
        public List<long?> JobIdList { get; set; }

        /// <summary>
        /// The ID of the namespace to which the job belongs. You can obtain the ID of the namespace on the **Namespace** page in the SchedulerX console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The source of the namespace. This parameter is required only for a special third party.
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// The ID of the region to which the job belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

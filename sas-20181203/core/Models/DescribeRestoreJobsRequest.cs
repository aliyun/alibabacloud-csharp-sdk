// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRestoreJobsRequest : TeaModel {
        /// <summary>
        /// The timestamp when the in-progress restoration task is expected to be complete. Unit: seconds.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The return value of the restoration task.
        /// </summary>
        [NameInMap("MachineRemark")]
        [Validation(Required=false)]
        public string MachineRemark { get; set; }

        /// <summary>
        /// The timestamp when the restoration task was last updated. Unit: milliseconds.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the file that is restored. Valid values:
        /// 
        /// *   **ECS_FILE**: files on Elastic Compute Service (ECS) instances
        /// *   **FILE**: files on servers in data centers
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

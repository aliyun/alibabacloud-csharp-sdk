// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListJobsRequest : TeaModel {
        /// <summary>
        /// The deployment ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// The page number. Minimum value: 1. Default value: 1.
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 10.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The collation.
        /// 
        /// Valid values:
        /// 
        /// *   gmt_create
        /// *   job_id
        /// *   status
        /// </summary>
        [NameInMap("sortName")]
        [Validation(Required=false)]
        public string SortName { get; set; }

    }

}

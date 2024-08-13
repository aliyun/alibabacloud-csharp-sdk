// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListDeploymentJobRequest : TeaModel {
        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The type of the deployment task.
        /// 
        /// Valid values:
        /// 
        /// *   cloud: multi-cloud deployment task.
        /// *   user: cloud service deployment task. This type of task does not support Elastic Compute Service (ECS) instances.
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// The number of certificates per page. Default value: **50**.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// The status of the deployment task.
        /// 
        /// Valid values:
        /// 
        /// *   success
        /// *   pending
        /// *   scheduling
        /// *   processing
        /// *   error
        /// *   editing
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}

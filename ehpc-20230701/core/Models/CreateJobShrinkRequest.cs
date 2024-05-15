// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20230701.Models
{
    public class CreateJobShrinkRequest : TeaModel {
        [NameInMap("DeploymentPolicy")]
        [Validation(Required=false)]
        public string DeploymentPolicyShrink { get; set; }

        [NameInMap("JobDescription")]
        [Validation(Required=false)]
        public string JobDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public string TasksShrink { get; set; }

    }

}

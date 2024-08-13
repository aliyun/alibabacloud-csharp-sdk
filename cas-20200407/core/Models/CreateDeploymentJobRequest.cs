// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateDeploymentJobRequest : TeaModel {
        /// <summary>
        /// The certificate IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

        /// <summary>
        /// The contact IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

        /// <summary>
        /// The type of the task.
        /// 
        /// Valid values:
        /// 
        /// *   cloud
        /// *   user
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// The name of the deployment task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The resource IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// The time when the task was scheduled.
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public long? ScheduleTime { get; set; }

    }

}

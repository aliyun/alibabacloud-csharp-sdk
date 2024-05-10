// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateOnceTaskRequest : TeaModel {
        /// <summary>
        /// The additional information.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// The source of the scan task.
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// The name of the scan task. Valid values:
        /// 
        /// *   **CLIENT_PROBLEM_CHECK**: a client diagnosis task
        /// *   **CLIENT_DEV_OPS**: an O\\&M task of Cloud Assistant
        /// *   **ASSET_SECURITY_CHECK**: a task of asset information collection
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the scan task. Valid values:
        /// 
        /// *   **CLIENT_PROBLEM_CHECK**: a client diagnosis task
        /// *   **CLIENT_DEV_OPS**: an O\\&M task of Cloud Assistant
        /// *   **ASSET_SECURITY_CHECK**: a task of asset information collection
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}

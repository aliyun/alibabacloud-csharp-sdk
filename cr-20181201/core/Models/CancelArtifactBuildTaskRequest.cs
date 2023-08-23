/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CancelArtifactBuildTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the artifact building task.
        /// </summary>
        [NameInMap("BuildTaskId")]
        [Validation(Required=false)]
        public string BuildTaskId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}

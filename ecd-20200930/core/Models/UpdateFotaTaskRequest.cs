// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class UpdateFotaTaskRequest : TeaModel {
        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the regions supported by WUYING Workspace.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the image update task. You can call the [DescribeFotaTasks](~~437001~~) operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("TaskUid")]
        [Validation(Required=false)]
        public string TaskUid { get; set; }

        /// <summary>
        /// Specifies whether to automatically push the image update task.
        /// 
        /// Valid values:
        /// 
        /// *   Running: automatically pushes the image update task.
        /// *   Pending: does not automatically push the image update task.
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public string UserStatus { get; set; }

    }

}

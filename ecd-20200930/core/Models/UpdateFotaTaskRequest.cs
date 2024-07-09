// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class UpdateFotaTaskRequest : TeaModel {
        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the regions supported by Elastic Desktop Service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the image update task. You can call the [DescribeFotaTasks](https://help.aliyun.com/document_detail/437001.html) operation to obtain the value of this parameter.
        /// 
        /// This parameter is required.
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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeDeploymentJobRequest : TeaModel {
        /// <summary>
        /// The ID of the deployment job. The **ID** of the job is returned after you call the [CreateDeploymentJob](https://help.aliyun.com/document_detail/2712234.html) operation. You can also call the [ListDeploymentJob](https://help.aliyun.com/document_detail/2712223.html) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

    }

}

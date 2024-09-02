// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class UpdateABTestExperimentRequest : TeaModel {
        /// <summary>
        /// The request body. For more information, see [ABTestExperiment](https://help.aliyun.com/document_detail/173617.html).
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ABTestExperiment Body { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. No endpoint is created. The system checks whether your AccessKey is valid, whether Resource Access Management (RAM) users are authorized, and whether the required parameters are set.
        /// *   false (default): creates an endpoint immediately.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}

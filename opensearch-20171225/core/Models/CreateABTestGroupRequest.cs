// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateABTestGroupRequest : TeaModel {
        /// <summary>
        /// The request body. For more information, see [ABTestGroup](https://help.aliyun.com/document_detail/178935.html).
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ABTestGroup Body { get; set; }

        /// <summary>
        /// Specifies whether to check the validity of input parameters. Default value: false.
        /// 
        /// Valid values:
        /// 
        /// *   **true**: checks only the validity of input parameters.
        /// *   **false**: checks the validity of input parameters and creates an attribution configuration.
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}

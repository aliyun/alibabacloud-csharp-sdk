// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBResourceManagementModeResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource management mode. Valid values:
        /// 
        /// *   resourceGroup: resource group management.
        /// *   resourceQueue: resource queue management.
        /// </summary>
        [NameInMap("ResourceManagementMode")]
        [Validation(Required=false)]
        public string ResourceManagementMode { get; set; }

    }

}

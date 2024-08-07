// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespaceListRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return custom namespaces. Valid values:
        /// 
        /// *   **true**: The system returns custom namespaces.
        /// *   **false**: The system does not return custom namespaces.
        /// </summary>
        [NameInMap("ContainCustom")]
        [Validation(Required=false)]
        public bool? ContainCustom { get; set; }

        /// <summary>
        /// Specifies whether to exclude hybrid cloud namespaces from the result. Valid values:
        /// 
        /// - **true**: The system excludes hybrid cloud namespaces from the result.
        /// - **false**: The system does not exclude hybrid cloud namespaces from the result.
        /// </summary>
        [NameInMap("HybridCloudExclude")]
        [Validation(Required=false)]
        public bool? HybridCloudExclude { get; set; }

    }

}

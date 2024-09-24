// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CleanClusterUserPermissionsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcefully delete the specified kubeconfig files. Valid values:
        /// 
        /// *   false (default): checks the cluster access records within the previous seven days before deleting the kubeconfig files. The kubeconfig files are not deleted if cluster access records are found or fail to be retrieved.
        /// *   true: forcefully deletes the kubeconfig files without checking the cluster access records.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClusterCnnfStatusUserConfirmRequest : TeaModel {
        /// <summary>
        /// The cluster IDs.
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

        /// <summary>
        /// Specifies whether to fix the blocking status of the cluster. Valid values:
        /// 
        /// *   true: yes
        /// *   false: no
        /// </summary>
        [NameInMap("UserConfirm")]
        [Validation(Required=false)]
        public bool? UserConfirm { get; set; }

    }

}

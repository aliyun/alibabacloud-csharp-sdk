// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetClusterInterceptionConfigRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster. Separate multiple cluster IDs with commas (,).
        /// 
        /// > You can call the [ListClusterInterceptionConfig](~~ListClusterInterceptionConfig~~) operation to query the IDs of clusters.
        /// </summary>
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public string ClusterIds { get; set; }

        /// <summary>
        /// Specifies whether to turn on the switch. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("SwitchOn")]
        [Validation(Required=false)]
        public int? SwitchOn { get; set; }

        /// <summary>
        /// The type of the switch that you want to configure. Valid values:
        /// 
        /// *   **0**: the interception switch
        /// *   **1**: the interception type switch
        /// *   **2**: the interception history switch
        /// </summary>
        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public int? SwitchType { get; set; }

    }

}

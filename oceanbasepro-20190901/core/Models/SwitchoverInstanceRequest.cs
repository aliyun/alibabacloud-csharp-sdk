// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class SwitchoverInstanceRequest : TeaModel {
        /// <summary>
        /// Whether to force the switchover.
        /// - true: Force the switchover.
        /// - false: Do not force the switchover.
        /// </summary>
        [NameInMap("Forced")]
        [Validation(Required=false)]
        public bool? Forced { get; set; }

        /// <summary>
        /// The instance ID of the primary/standby instance. You can set the default value to the instance ID of the instance to be switched to the primary instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The instance ID of the instance to be switched to the primary instance.
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

    }

}

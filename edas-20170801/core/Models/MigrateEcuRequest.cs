// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class MigrateEcuRequest : TeaModel {
        /// <summary>
        /// The ID of the ECS instance. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// The ID of the custom namespace.
        /// 
        /// *   The ID of a custom namespace is in the `region ID:custom namespace ID` format. Example: cn-beijing:tdy218.
        /// *   The ID of the default namespace is in the `region ID` format. Example: cn-beijing.
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

    }

}

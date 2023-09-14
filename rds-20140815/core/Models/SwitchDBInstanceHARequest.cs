// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class SwitchDBInstanceHARequest : TeaModel {
        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The time when the switching takes effect. Valid values:
        /// 
        /// *   **Immediate**: The switching immediately takes effect.
        /// *   **MaintainTime**: The switching takes effect during the maintenance time.
        /// 
        /// Default value: **Immediate**.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// Specifies whether to enable forcible switching. Valid values:
        /// 
        /// *   **Yes**
        /// *   **No**
        /// 
        /// Default value: **No**.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public string Force { get; set; }

        /// <summary>
        /// The globally unique identifier (GUID) of the secondary instance. You can call the [DescribeDBInstanceHAConfig](~~610434~~) operation to query the GUID of the secondary instance.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

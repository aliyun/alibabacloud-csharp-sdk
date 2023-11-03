// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDasInstanceConfigRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic storage expansion. Valid values:
        /// 
        /// *   **Enable**
        /// *   **Disable**
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// The threshold in percentage based on which an automatic storage expansion is triggered. If the available storage reaches the threshold, ApsaraDB RDS increases the storage capacity of the instance. Valid values:
        /// 
        /// *   **10**
        /// *   **20**
        /// *   **30**
        /// *   **40**
        /// *   **50**
        /// 
        /// >  If you set the StorageAutoScale parameter to **Enable**, you must specify this parameter.
        /// </summary>
        [NameInMap("StorageThreshold")]
        [Validation(Required=false)]
        public int? StorageThreshold { get; set; }

        /// <summary>
        /// The maximum storage capacity that is allowed for an automatic storage expansion. The value of this parameter must be greater than or equal to the current storage capacity of the RDS instance.
        /// 
        /// *   If the RDS instance uses ESSDs, the maximum value of this parameter can be set to 32000 GB.
        /// *   If the RDS instance uses standard SSDs, the maximum value of this parameter can be set to 6000 GB.
        /// 
        /// >  If you set the **StorageAutoScale** parameter to **Enable**, you must specify this parameter.
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public int? StorageUpperBound { get; set; }

    }

}

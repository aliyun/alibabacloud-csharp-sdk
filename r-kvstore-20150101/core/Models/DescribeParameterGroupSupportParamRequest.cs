// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupSupportParamRequest : TeaModel {
        /// <summary>
        /// The service category. Valid values:
        /// 
        /// *   **standard**: ApsaraDB for Redis Community Edition
        /// *   **enterprise**: ApsaraDB for Redis Enhanced Edition (Tair)
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The engine type. Valid values:
        /// 
        /// *   **redis**: ApsaraDB for Redis Community Edition instance or Tair DRAM-based instance
        /// *   **tair_pena**: Tair persistent memory-optimized instance
        /// *   **tair_pdb**: Tair ESSD/SSD-based instance
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// The compatible engine version. Valid values:
        /// 
        /// *   For ApsaraDB for Redis Community Edition instances, set the parameter to **5.0**, **6.0**, or **7.0**.
        /// *   For Tair DRAM-based instances that are compatible with Redis 5.0 or Redis 6.0, set the parameter to **5.0** or **6.0**.
        /// *   For Tair persistent memory-optimized instances that are compatible with Redis 6.0, set the parameter to **1.0**.
        /// *   For Tair ESSD-based instances that are compatible with Redis 6.0, set the parameter to **1.0**. For Tair SSD-based instances that are compatible with Redis 6.0, set the parameter to **2.0**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}

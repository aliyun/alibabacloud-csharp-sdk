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
        /// *   **standard**: Community Edition
        /// *   **enterprise**: Enhanced Edition (Tair)
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The engine type. Valid values:
        /// 
        /// *   **redis**: Redis or Tair DRAM-based instances
        /// *   **tair_pena**: Tair persistent memory-optimized instances
        /// *   **tair_pdb**: Tair ESSD-based instances
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// The engine version.
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

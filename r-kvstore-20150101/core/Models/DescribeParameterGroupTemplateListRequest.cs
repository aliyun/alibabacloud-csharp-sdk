// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupTemplateListRequest : TeaModel {
        /// <summary>
        /// The service category. Valid values:
        /// 
        /// standard: Community Edition enterprise: Enhanced Edition (Tair)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The role of the instance. Valid values: logic: logical instance. db: database instance. proxy: proxy node. cs: ConfigServer node. normal: master-replica database instance.
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// The engine type. Valid values:
        /// 
        /// redis: Redis or Tair DRAM-based instance tair_pena: Tair persistent memory-optimized instance tair_pdb: Tair ESSD-based instance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// The compatible engine version. Valid values:
        /// 
        /// ApsaraDB for Redis Community Edition: 5.0, 6.0, and 7.0. Tair DRAM-based instances: 5.0 and 6.0. Tair persistent memory-optimized instances: 6.0. Tair ESSD-based instances: 4.0.
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

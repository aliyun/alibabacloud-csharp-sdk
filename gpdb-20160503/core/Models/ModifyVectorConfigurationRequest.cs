// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyVectorConfigurationRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// >  You can call the [DescribeDBInstances](~~86911~~) operation to query the IDs of all AnalyticDB for PostgreSQL instances in a region.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to enable vector engine optimization. Valid values:
        /// 
        /// *   **enabled**
        /// *   **disabled**
        /// 
        /// > *   We recommend that you **do not enable** vector engine optimization in mainstream analysis and real-time data warehousing scenarios.
        /// > *   We recommend that you **enable** vector engine optimization in AI Generated Content (AIGC) and vector retrieval scenarios that require the vector analysis engine.
        /// </summary>
        [NameInMap("VectorConfigurationStatus")]
        [Validation(Required=false)]
        public string VectorConfigurationStatus { get; set; }

    }

}

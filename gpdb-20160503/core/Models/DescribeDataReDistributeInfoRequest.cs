// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDataReDistributeInfoRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// > You can call the [DescribeDBInstances](~~86911~~) operation to query the IDs of all AnalyticDB for PostgreSQL instances within a region.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteProcessInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~612397~~) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The ID of the workflow instance.
        /// </summary>
        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public long? ProcessInstanceId { get; set; }

        /// <summary>
        /// The project ID, which is the unique identifier of the project.
        /// </summary>
        [NameInMap("ProjectCode")]
        [Validation(Required=false)]
        public long? ProjectCode { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

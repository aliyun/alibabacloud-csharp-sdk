// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteProcessInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/612397.html) operation to query the IDs of all AnalyticDB for MySQL clusters within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The ID of the workflow instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProcessInstanceId")]
        [Validation(Required=false)]
        public long? ProcessInstanceId { get; set; }

        /// <summary>
        /// The project ID, which is the unique identifier of the project.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectCode")]
        [Validation(Required=false)]
        public long? ProjectCode { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

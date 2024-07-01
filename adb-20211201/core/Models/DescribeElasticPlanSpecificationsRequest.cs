// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlanSpecificationsRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// >  You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/454250.html) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified only when you query the resource specifications that are supported by an interactive resource group.
        /// 
        /// *   You can call the [DescribeDBResourceGroup](https://help.aliyun.com/document_detail/459446.html) operation to query the name of a resource group within a cluster.
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The type of the scaling plan. Valid values:
        /// 
        /// *   EXECUTOR: the interactive resource group type, which specifies the computing resource type.
        /// *   WORKER: the elastic I/O unit (EIU) type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

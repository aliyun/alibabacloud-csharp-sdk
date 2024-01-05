// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteElasticPlanRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the scaling plan.
        /// 
        /// >  You can call the [DescribeElasticPlans](~~601334~~) operation to query the names of scaling plans.
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

    }

}

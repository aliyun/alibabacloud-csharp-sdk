// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeWaitingSQLInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the instance IDs of all AnalyticDB for PostgreSQL instances in a specific region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The name of the database.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// The ID of the process that uniquely identifies the query.
        /// 
        /// >  You can call the [DescribeWaitingSQLRecords](https://help.aliyun.com/document_detail/461735.html) operation to obtain the process IDs of lock-waiting queries.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PID")]
        [Validation(Required=false)]
        public string PID { get; set; }

    }

}

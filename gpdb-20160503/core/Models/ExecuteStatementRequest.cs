// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ExecuteStatementRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// >  You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
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

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The configuration parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<object> Parameters { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The execution type. Valid values:
        /// 
        /// *   synchronous
        /// *   asynchronous (not supported)
        /// </summary>
        [NameInMap("RunType")]
        [Validation(Required=false)]
        public string RunType { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the access credential for the created Data API account. You can call the CreateSecret operation to create an access credential.
        /// 
        /// >  To call the ExecuteStatement operation as a Resource Access Management (RAM) user, the RAM user must have the permissions to call the UseSecret or GetSecretValue operation on the ARN of the access credential.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretArn")]
        [Validation(Required=false)]
        public string SecretArn { get; set; }

        /// <summary>
        /// The SQL statements that you want to execute.
        /// </summary>
        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        /// <summary>
        /// The SQL statements.
        /// </summary>
        [NameInMap("Sqls")]
        [Validation(Required=false)]
        public List<string> Sqls { get; set; }

        /// <summary>
        /// The name of the set of SQL statements that you want to execute. This parameter takes effect when the RunType parameter is set to asynchronous.
        /// </summary>
        [NameInMap("StatementName")]
        [Validation(Required=false)]
        public string StatementName { get; set; }

    }

}

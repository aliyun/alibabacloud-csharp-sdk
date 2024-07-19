// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ExecuteStatementRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<object> Parameters { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RunType")]
        [Validation(Required=false)]
        public string RunType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretArn")]
        [Validation(Required=false)]
        public string SecretArn { get; set; }

        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        [NameInMap("Sqls")]
        [Validation(Required=false)]
        public List<string> Sqls { get; set; }

        [NameInMap("StatementName")]
        [Validation(Required=false)]
        public string StatementName { get; set; }

    }

}

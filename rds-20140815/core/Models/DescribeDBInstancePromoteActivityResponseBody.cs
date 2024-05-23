// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBInstancePromoteActivityResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public string AliUid { get; set; }

        /// <summary>
        /// *   China site: 26842
        /// *   International site: 26888
        /// </summary>
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/26232.html) operation to query the instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The instance name.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// The type of the database engine. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **PostgreSQL**
        /// *   **Oracle**
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// The activity information about the instance. For more information, see [Instance activities](https://help.aliyun.com/document_detail/2391834.html).
        /// </summary>
        [NameInMap("IsActivity")]
        [Validation(Required=false)]
        public string IsActivity { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

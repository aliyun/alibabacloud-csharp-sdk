// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RenewInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment during the renewal. Valid values:
        /// 
        /// *   **True**: enables automatic payment. Make sure that your Alibaba Cloud account has adequate balance.
        /// *   **False** (default): disables automatic payment. You have to manually pay the order in the console.
        /// 
        /// >  For more information about how to renew the instance in the console, see the following topics:
        /// 
        /// *   [Manually renew an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/96050.html)
        /// 
        /// *   [Manually renew an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96741.html)
        /// 
        /// *   [Manually renew an ApsaraDB RDS for SQL Server instance](https://help.aliyun.com/document_detail/95637.html)
        /// 
        /// *   [Manually renew an ApsaraDB RDS for MariaDB instance](https://help.aliyun.com/document_detail/97122.html)
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public string AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal for the instance. Valid values:
        /// 
        /// *   **true**.
        /// *   **false** (default)
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The instance ID You can call the DescribeDBInstances operation to query the instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The duration of the subscription renewal. Unit: month. Valid values:
        /// 
        /// *   **1~9**
        /// *   **12**
        /// *   **24**
        /// *   **36**
        /// *   **48**
        /// *   **60**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}

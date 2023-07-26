// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// An invalid parameter. It is no longer returned when you call this operation.
        /// 
        /// You can call the [DescribeDBInstanceAttribute](~~86910~~) operation to query the endpoint that is used to connect to the instance.
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The order ID.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// An invalid parameter. It is no longer returned when you call this operation.
        /// 
        /// You can call the [DescribeDBInstanceAttribute](~~86910~~) operation to query the port number that is used to connect to the instance.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

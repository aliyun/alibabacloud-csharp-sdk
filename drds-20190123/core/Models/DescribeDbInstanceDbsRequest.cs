// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDbInstanceDbsRequest : TeaModel {
        /// <summary>
        /// The name of the privileged account of the PolarDB-X 1.0 instance. You do not need to specify this parameter if you have no privileged account.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The engine type of the storage-layer databases. Valid values: **POLARDB** and **RDS**.
        /// </summary>
        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        /// <summary>
        /// The ID of the instance in which the storage-layer databases are deployed.
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// The password of the privileged account. You do not need to specify this parameter if you have no privileged account.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}

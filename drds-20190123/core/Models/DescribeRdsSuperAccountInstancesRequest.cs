// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsSuperAccountInstancesRequest : TeaModel {
        /// <summary>
        /// The type of the ApsaraDB RDS for MySQL instances. Default value: **RDS**.
        /// </summary>
        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        /// <summary>
        /// The ID of the PolarDB-X 1.0 instance.
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("RdsInstance")]
        [Validation(Required=false)]
        public List<string> RdsInstance { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRdsReadOnlyRequest : TeaModel {
        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("RdsInstanceId")]
        [Validation(Required=false)]
        public string RdsInstanceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeConfigVersionDifferenceRequest : TeaModel {
        [NameInMap("ChangeId")]
        [Validation(Required=false)]
        public string ChangeId { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class DescribeComponentRequest : TeaModel {
        [NameInMap("RenderTemplate")]
        [Validation(Required=false)]
        public bool? RenderTemplate { get; set; }

        [NameInMap("Values")]
        [Validation(Required=false)]
        public Dictionary<string, object> Values { get; set; }

    }

}

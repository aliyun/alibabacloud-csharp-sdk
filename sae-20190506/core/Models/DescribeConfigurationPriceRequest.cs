// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeConfigurationPriceRequest : TeaModel {
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("Workload")]
        [Validation(Required=false)]
        public string Workload { get; set; }

    }

}

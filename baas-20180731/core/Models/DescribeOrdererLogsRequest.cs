// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeOrdererLogsRequest : TeaModel {
        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public string Lines { get; set; }

        [NameInMap("OrdererName")]
        [Validation(Required=false)]
        public string OrdererName { get; set; }

    }

}

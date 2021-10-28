// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayStatisticsRequest : TeaModel {
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        [NameInMap("GatewayCategory")]
        [Validation(Required=false)]
        public string GatewayCategory { get; set; }

        [NameInMap("GatewayLocation")]
        [Validation(Required=false)]
        public string GatewayLocation { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        [NameInMap("TargetAccountId")]
        [Validation(Required=false)]
        public string TargetAccountId { get; set; }

    }

}

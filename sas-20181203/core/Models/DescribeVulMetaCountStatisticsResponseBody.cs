// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulMetaCountStatisticsResponseBody : TeaModel {
        [NameInMap("AppCount")]
        [Validation(Required=false)]
        public int? AppCount { get; set; }

        [NameInMap("CveCount")]
        [Validation(Required=false)]
        public int? CveCount { get; set; }

        [NameInMap("RaspDefendCount")]
        [Validation(Required=false)]
        public int? RaspDefendCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SysCount")]
        [Validation(Required=false)]
        public int? SysCount { get; set; }

    }

}

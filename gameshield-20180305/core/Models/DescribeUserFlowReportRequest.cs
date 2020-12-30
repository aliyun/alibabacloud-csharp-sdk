// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeUserFlowReportRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("EsnGroupId")]
        [Validation(Required=false)]
        public string EsnGroupId { get; set; }

        [NameInMap("EsnBizId")]
        [Validation(Required=false)]
        public long? EsnBizId { get; set; }

        [NameInMap("EsnAppId")]
        [Validation(Required=false)]
        public string EsnAppId { get; set; }

    }

}

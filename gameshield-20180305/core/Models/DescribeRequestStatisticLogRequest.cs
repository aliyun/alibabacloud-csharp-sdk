// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeRequestStatisticLogRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("EsnApp")]
        [Validation(Required=false)]
        public string EsnApp { get; set; }

        [NameInMap("EsnBiz")]
        [Validation(Required=false)]
        public string EsnBiz { get; set; }

        [NameInMap("EsnGroup")]
        [Validation(Required=false)]
        public string EsnGroup { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("SDK")]
        [Validation(Required=false)]
        public string SDK { get; set; }

        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("EscapedLessThan")]
        [Validation(Required=false)]
        public long? EscapedLessThan { get; set; }

        [NameInMap("EscapedGreaterThan")]
        [Validation(Required=false)]
        public long? EscapedGreaterThan { get; set; }

        [NameInMap("DetectIp")]
        [Validation(Required=false)]
        public string DetectIp { get; set; }

    }

}

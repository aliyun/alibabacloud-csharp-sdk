// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeRequestStatisticCountByEsnBiz30MRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("EsnApp")]
        [Validation(Required=false)]
        public string EsnApp { get; set; }

        [NameInMap("EsnBiz")]
        [Validation(Required=false)]
        public string EsnBiz { get; set; }

        [NameInMap("Time")]
        [Validation(Required=false)]
        public long? Time { get; set; }

    }

}

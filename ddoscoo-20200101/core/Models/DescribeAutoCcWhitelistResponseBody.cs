// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcWhitelistResponseBody : TeaModel {
        [NameInMap("AutoCcWhitelist")]
        [Validation(Required=false)]
        public List<DescribeAutoCcWhitelistResponseBodyAutoCcWhitelist> AutoCcWhitelist { get; set; }
        public class DescribeAutoCcWhitelistResponseBodyAutoCcWhitelist : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("DestIp")]
            [Validation(Required=false)]
            public string DestIp { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

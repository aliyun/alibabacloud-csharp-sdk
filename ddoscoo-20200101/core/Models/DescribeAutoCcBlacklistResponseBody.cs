// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcBlacklistResponseBody : TeaModel {
        [NameInMap("AutoCcBlacklist")]
        [Validation(Required=false)]
        public List<DescribeAutoCcBlacklistResponseBodyAutoCcBlacklist> AutoCcBlacklist { get; set; }
        public class DescribeAutoCcBlacklistResponseBodyAutoCcBlacklist : TeaModel {
            [NameInMap("DestIp")]
            [Validation(Required=false)]
            public string DestIp { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

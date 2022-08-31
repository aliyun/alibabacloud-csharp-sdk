// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDBMiniEngineVersionsResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        [NameInMap("MinorVersionItems")]
        [Validation(Required=false)]
        public List<DescribeDBMiniEngineVersionsResponseBodyMinorVersionItems> MinorVersionItems { get; set; }
        public class DescribeDBMiniEngineVersionsResponseBodyMinorVersionItems : TeaModel {
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("IsHotfixVersion")]
            [Validation(Required=false)]
            public bool? IsHotfixVersion { get; set; }

            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            [NameInMap("ReleaseType")]
            [Validation(Required=false)]
            public string ReleaseType { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

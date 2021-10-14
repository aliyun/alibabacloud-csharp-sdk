// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitDetailResponseBody : TeaModel {
        [NameInMap("DataLimit")]
        [Validation(Required=false)]
        public DescribeDataLimitDetailResponseBodyDataLimit DataLimit { get; set; }
        public class DescribeDataLimitDetailResponseBodyDataLimit : TeaModel {
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public int? CheckStatus { get; set; }
            [NameInMap("CheckStatusName")]
            [Validation(Required=false)]
            public string CheckStatusName { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public long? ResourceType { get; set; }
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

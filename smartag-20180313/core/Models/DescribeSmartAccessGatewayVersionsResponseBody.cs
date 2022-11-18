// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSmartAccessGatewayVersionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SmartAGVersions")]
        [Validation(Required=false)]
        public DescribeSmartAccessGatewayVersionsResponseBodySmartAGVersions SmartAGVersions { get; set; }
        public class DescribeSmartAccessGatewayVersionsResponseBodySmartAGVersions : TeaModel {
            [NameInMap("SmartAGVersion")]
            [Validation(Required=false)]
            public List<DescribeSmartAccessGatewayVersionsResponseBodySmartAGVersionsSmartAGVersion> SmartAGVersion { get; set; }
            public class DescribeSmartAccessGatewayVersionsResponseBodySmartAGVersionsSmartAGVersion : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

        }

    }

}

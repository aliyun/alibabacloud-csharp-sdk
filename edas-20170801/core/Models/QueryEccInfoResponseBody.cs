// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryEccInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("EccInfo")]
        [Validation(Required=false)]
        public QueryEccInfoResponseBodyEccInfo EccInfo { get; set; }
        public class QueryEccInfoResponseBodyEccInfo : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("EccId")]
            [Validation(Required=false)]
            public string EccId { get; set; }
            [NameInMap("EcuId")]
            [Validation(Required=false)]
            public string EcuId { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("PackageMd5")]
            [Validation(Required=false)]
            public string PackageMd5 { get; set; }
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

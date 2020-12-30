// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DescribeAlgoLibsResponseBody : TeaModel {
        [NameInMap("AlgoLibs")]
        [Validation(Required=false)]
        public DescribeAlgoLibsResponseBodyAlgoLibs AlgoLibs { get; set; }
        public class DescribeAlgoLibsResponseBodyAlgoLibs : TeaModel {
            [NameInMap("AlgoLib")]
            [Validation(Required=false)]
            public List<DescribeAlgoLibsResponseBodyAlgoLibsAlgoLib> AlgoLib { get; set; }
            public class DescribeAlgoLibsResponseBodyAlgoLibsAlgoLib : TeaModel {
                public string OssAccessKeyId { get; set; }
                public string Capacity { get; set; }
                public string AlgoLibId { get; set; }
                public string JsonText { get; set; }
                public string AlgoLibVersion { get; set; }
                public string AlgoLibName { get; set; }
                public string Text { get; set; }
                public string OssBucket { get; set; }
                public string CapabilityNames { get; set; }
                public string OssPath { get; set; }
                public string OssEndpoint { get; set; }
                public string UploadTime { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}

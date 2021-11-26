// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationImageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationImageResponseBodyData Data { get; set; }
        public class DescribeApplicationImageResponseBodyData : TeaModel {
            [NameInMap("CrUrl")]
            [Validation(Required=false)]
            public string CrUrl { get; set; }
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }
            [NameInMap("RepoOriginType")]
            [Validation(Required=false)]
            public string RepoOriginType { get; set; }
            [NameInMap("RepoTag")]
            [Validation(Required=false)]
            public string RepoTag { get; set; }
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListVersionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<ListVersionsResponseBodyVersions> Versions { get; set; }
        public class ListVersionsResponseBodyVersions : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public int? VersionName { get; set; }

            [NameInMap("VersionStatus")]
            [Validation(Required=false)]
            public int? VersionStatus { get; set; }

        }

    }

}

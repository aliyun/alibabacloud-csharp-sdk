// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class ListVersionsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Versions")]
        [Validation(Required=true)]
        public List<ListVersionsResponseVersions> Versions { get; set; }
        public class ListVersionsResponseVersions : TeaModel {
            [NameInMap("VersionId")]
            [Validation(Required=true)]
            public string VersionId { get; set; }

            [NameInMap("FlowId")]
            [Validation(Required=true)]
            public string FlowId { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=true)]
            public int? VersionName { get; set; }

            [NameInMap("VersionStatus")]
            [Validation(Required=true)]
            public int? VersionStatus { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }

        }

    }

}

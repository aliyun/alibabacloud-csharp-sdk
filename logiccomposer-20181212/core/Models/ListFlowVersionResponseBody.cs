// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Logiccomposer20181212.Models
{
    public class ListFlowVersionResponseBody : TeaModel {
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<ListFlowVersionResponseBodyVersions> Versions { get; set; }
        public class ListFlowVersionResponseBodyVersions : TeaModel {
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public int? State { get; set; }

            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("FlowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

        }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}

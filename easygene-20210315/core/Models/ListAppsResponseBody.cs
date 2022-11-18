// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListAppsResponseBody : TeaModel {
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public List<ListAppsResponseBodyApps> Apps { get; set; }
        public class ListAppsResponseBodyApps : TeaModel {
            [NameInMap("AppDefaultVersion")]
            [Validation(Required=false)]
            public string AppDefaultVersion { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

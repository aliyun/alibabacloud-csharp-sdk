// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListGlobalAppsResponseBody : TeaModel {
        [NameInMap("GlobalApps")]
        [Validation(Required=false)]
        public List<ListGlobalAppsResponseBodyGlobalApps> GlobalApps { get; set; }
        public class ListGlobalAppsResponseBodyGlobalApps : TeaModel {
            [NameInMap("AppDefaultVersion")]
            [Validation(Required=false)]
            public string AppDefaultVersion { get; set; }

            [NameInMap("AppDescription")]
            [Validation(Required=false)]
            public string AppDescription { get; set; }

            [NameInMap("AppFee")]
            [Validation(Required=false)]
            public string AppFee { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppScope")]
            [Validation(Required=false)]
            public string AppScope { get; set; }

            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<string> Locations { get; set; }

            [NameInMap("NamespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            [NameInMap("Pinned")]
            [Validation(Required=false)]
            public bool? Pinned { get; set; }

            [NameInMap("Toolkit")]
            [Validation(Required=false)]
            public string Toolkit { get; set; }

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
        public long? TotalCount { get; set; }

    }

}

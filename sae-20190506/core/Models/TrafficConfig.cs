// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class TrafficConfig : TeaModel {
        [NameInMap("additionalVersionWeight")]
        [Validation(Required=false)]
        public Dictionary<string, float?> AdditionalVersionWeight { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resolvePolicy")]
        [Validation(Required=false)]
        public string ResolvePolicy { get; set; }

        [NameInMap("routePolicy")]
        [Validation(Required=false)]
        public RoutePolicy RoutePolicy { get; set; }

        [NameInMap("versionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}

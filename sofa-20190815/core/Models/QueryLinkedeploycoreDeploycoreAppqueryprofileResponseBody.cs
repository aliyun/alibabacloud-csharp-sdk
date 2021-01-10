// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreAppqueryprofileResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLinkedeploycoreDeploycoreAppqueryprofileResponseBodyData Data { get; set; }
        public class QueryLinkedeploycoreDeploycoreAppqueryprofileResponseBodyData : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("DefaultBuildPackVersion")]
            [Validation(Required=false)]
            public string DefaultBuildPackVersion { get; set; }
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }
            [NameInMap("FrontApp")]
            [Validation(Required=false)]
            public bool? FrontApp { get; set; }
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("StationName")]
            [Validation(Required=false)]
            public string StationName { get; set; }
            [NameInMap("TechStack")]
            [Validation(Required=false)]
            public string TechStack { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }
            [NameInMap("BuildPackVersions")]
            [Validation(Required=false)]
            public List<string> BuildPackVersions { get; set; }
            [NameInMap("Customized")]
            [Validation(Required=false)]
            public List<string> Customized { get; set; }
            [NameInMap("Iteration")]
            [Validation(Required=false)]
            public List<string> Iteration { get; set; }
            [NameInMap("LatestTag")]
            [Validation(Required=false)]
            public List<string> LatestTag { get; set; }
            [NameInMap("Sidecars")]
            [Validation(Required=false)]
            public List<string> Sidecars { get; set; }
            [NameInMap("Trunk")]
            [Validation(Required=false)]
            public List<string> Trunk { get; set; }
            [NameInMap("ZoneList")]
            [Validation(Required=false)]
            public List<string> ZoneList { get; set; }
        };

    }

}

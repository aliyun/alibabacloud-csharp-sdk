// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricNewappinfoResponseBody : TeaModel {
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
        public List<QueryLinkefabricFabricNewappinfoResponseBodyData> Data { get; set; }
        public class QueryLinkefabricFabricNewappinfoResponseBodyData : TeaModel {
            [NameInMap("AntxVersion")]
            [Validation(Required=false)]
            public string AntxVersion { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("BaseJar")]
            [Validation(Required=false)]
            public bool? BaseJar { get; set; }

            [NameInMap("ConfigBak")]
            [Validation(Required=false)]
            public bool? ConfigBak { get; set; }

            [NameInMap("DevStage")]
            [Validation(Required=false)]
            public string DevStage { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("GrayRelease")]
            [Validation(Required=false)]
            public bool? GrayRelease { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("IsNewApp")]
            [Validation(Required=false)]
            public bool? IsNewApp { get; set; }

            [NameInMap("IsRollback")]
            [Validation(Required=false)]
            public bool? IsRollback { get; set; }

            [NameInMap("OriginReleaseIds")]
            [Validation(Required=false)]
            public string OriginReleaseIds { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ReleaseId")]
            [Validation(Required=false)]
            public string ReleaseId { get; set; }

            [NameInMap("SandboxRelease")]
            [Validation(Required=false)]
            public bool? SandboxRelease { get; set; }

            [NameInMap("Station")]
            [Validation(Required=false)]
            public string Station { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public long? UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public long? UtcModified { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCASAppserviceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCASAppserviceResponseBodyData> Data { get; set; }
        public class QueryCASAppserviceResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("BuildpackFullVersion")]
            [Validation(Required=false)]
            public string BuildpackFullVersion { get; set; }

            [NameInMap("BuildpackId")]
            [Validation(Required=false)]
            public string BuildpackId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExtendProperties")]
            [Validation(Required=false)]
            public string ExtendProperties { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("IsService")]
            [Validation(Required=false)]
            public bool? IsService { get; set; }

            [NameInMap("LastDeployStatus")]
            [Validation(Required=false)]
            public string LastDeployStatus { get; set; }

            [NameInMap("LastDeployVersion")]
            [Validation(Required=false)]
            public string LastDeployVersion { get; set; }

            [NameInMap("LastOpsOrderId")]
            [Validation(Required=false)]
            public string LastOpsOrderId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("TechstackId")]
            [Validation(Required=false)]
            public long? TechstackId { get; set; }

            [NameInMap("TechstackIdentity")]
            [Validation(Required=false)]
            public string TechstackIdentity { get; set; }

            [NameInMap("TechstackName")]
            [Validation(Required=false)]
            public string TechstackName { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("CellIds")]
            [Validation(Required=false)]
            public List<string> CellIds { get; set; }

        }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricDetailbytypeResponseBody : TeaModel {
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
        public List<QueryLinkefabricFabricDetailbytypeResponseBodyData> Data { get; set; }
        public class QueryLinkefabricFabricDetailbytypeResponseBodyData : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("CommonState")]
            [Validation(Required=false)]
            public string CommonState { get; set; }

            [NameInMap("DevStage")]
            [Validation(Required=false)]
            public string DevStage { get; set; }

            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            [NameInMap("EnvDisplayName")]
            [Validation(Required=false)]
            public string EnvDisplayName { get; set; }

            [NameInMap("ExecuteDesc")]
            [Validation(Required=false)]
            public string ExecuteDesc { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("TaskInfo")]
            [Validation(Required=false)]
            public string TaskInfo { get; set; }

            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("TaskUrl")]
            [Validation(Required=false)]
            public string TaskUrl { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public long? UtcModified { get; set; }

        }

    }

}

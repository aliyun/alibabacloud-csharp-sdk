// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreAppservicequeryappserviceiddetailResponseBody : TeaModel {
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
        public QueryLinkedeploycoreDeploycoreAppservicequeryappserviceiddetailResponseBodyData Data { get; set; }
        public class QueryLinkedeploycoreDeploycoreAppservicequeryappserviceiddetailResponseBodyData : TeaModel {
            [NameInMap("ApplyOwner")]
            [Validation(Required=false)]
            public string ApplyOwner { get; set; }
            [NameInMap("AppInstanceGroup")]
            [Validation(Required=false)]
            public string AppInstanceGroup { get; set; }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AppServiceName")]
            [Validation(Required=false)]
            public string AppServiceName { get; set; }
            [NameInMap("BranchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }
            [NameInMap("CodeUrl")]
            [Validation(Required=false)]
            public string CodeUrl { get; set; }
            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }
            [NameInMap("CpuLimit")]
            [Validation(Required=false)]
            public string CpuLimit { get; set; }
            [NameInMap("CpuRequest")]
            [Validation(Required=false)]
            public string CpuRequest { get; set; }
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }
            [NameInMap("FirstCreate")]
            [Validation(Required=false)]
            public bool? FirstCreate { get; set; }
            [NameInMap("FromApp")]
            [Validation(Required=false)]
            public string FromApp { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }
            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public string MemoryLimit { get; set; }
            [NameInMap("MemoryRequest")]
            [Validation(Required=false)]
            public string MemoryRequest { get; set; }
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("PaasDetailUrl")]
            [Validation(Required=false)]
            public string PaasDetailUrl { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public long? Replicas { get; set; }
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }
            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }
        };

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricTechstackconfigsRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        [NameInMap("CiConfigId")]
        [Validation(Required=false)]
        public string CiConfigId { get; set; }

        [NameInMap("DevStage")]
        [Validation(Required=false)]
        public string DevStage { get; set; }

        [NameInMap("EmpId")]
        [Validation(Required=false)]
        public string EmpId { get; set; }

        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("IsProdUrl")]
        [Validation(Required=false)]
        public bool? IsProdUrl { get; set; }

        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public bool? IsPublic { get; set; }

        [NameInMap("NeedTransfer")]
        [Validation(Required=false)]
        public bool? NeedTransfer { get; set; }

        [NameInMap("NotifyDevStage")]
        [Validation(Required=false)]
        public string NotifyDevStage { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("OriginAppName")]
        [Validation(Required=false)]
        public string OriginAppName { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("QueryAll")]
        [Validation(Required=false)]
        public bool? QueryAll { get; set; }

        [NameInMap("QueryChange")]
        [Validation(Required=false)]
        public bool? QueryChange { get; set; }

        [NameInMap("ReleaseId")]
        [Validation(Required=false)]
        public string ReleaseId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

    }

}

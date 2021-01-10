// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class MountLinkedeploycoreDeploycoreAppserviceapplyRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppServiceId")]
        [Validation(Required=false)]
        public long? AppServiceId { get; set; }

        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        [NameInMap("CodeUrl")]
        [Validation(Required=false)]
        public string CodeUrl { get; set; }

        [NameInMap("CommandRepeatList")]
        [Validation(Required=false)]
        public List<string> CommandRepeatList { get; set; }

        [NameInMap("CommitId")]
        [Validation(Required=false)]
        public string CommitId { get; set; }

        [NameInMap("DynamicQuota")]
        [Validation(Required=false)]
        public bool? DynamicQuota { get; set; }

        [NameInMap("Environments")]
        [Validation(Required=false)]
        public string Environments { get; set; }

        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("ExtraRequest")]
        [Validation(Required=false)]
        public string ExtraRequest { get; set; }

        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("JavaOpts")]
        [Validation(Required=false)]
        public string JavaOpts { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("PureResources")]
        [Validation(Required=false)]
        public bool? PureResources { get; set; }

        [NameInMap("ReleaseId")]
        [Validation(Required=false)]
        public string ReleaseId { get; set; }

        [NameInMap("Replica")]
        [Validation(Required=false)]
        public string Replica { get; set; }

        [NameInMap("Runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("SidecarsRepeatList")]
        [Validation(Required=false)]
        public List<string> SidecarsRepeatList { get; set; }

        [NameInMap("SofaRouter")]
        [Validation(Required=false)]
        public string SofaRouter { get; set; }

        [NameInMap("Spanner")]
        [Validation(Required=false)]
        public bool? Spanner { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

    }

}

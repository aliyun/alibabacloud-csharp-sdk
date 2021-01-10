// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckLinkefabricFabricReleasepaascheckRequest : TeaModel {
        [NameInMap("AntxCloseAllSwitch")]
        [Validation(Required=false)]
        public bool? AntxCloseAllSwitch { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("CloudInfo")]
        [Validation(Required=false)]
        public string CloudInfo { get; set; }

        [NameInMap("DeployHandlerType")]
        [Validation(Required=false)]
        public string DeployHandlerType { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("GrayProjectId")]
        [Validation(Required=false)]
        public string GrayProjectId { get; set; }

        [NameInMap("GrayReleaseType")]
        [Validation(Required=false)]
        public string GrayReleaseType { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("PlanTime")]
        [Validation(Required=false)]
        public string PlanTime { get; set; }

        [NameInMap("ReleaseDomain")]
        [Validation(Required=false)]
        public string ReleaseDomain { get; set; }

        [NameInMap("ReleaseId")]
        [Validation(Required=false)]
        public string ReleaseId { get; set; }

        [NameInMap("ReleaseOrderType")]
        [Validation(Required=false)]
        public string ReleaseOrderType { get; set; }

        [NameInMap("ReleasePubWay")]
        [Validation(Required=false)]
        public string ReleasePubWay { get; set; }

        [NameInMap("ReleaseType")]
        [Validation(Required=false)]
        public string ReleaseType { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("UseBaseline")]
        [Validation(Required=false)]
        public bool? UseBaseline { get; set; }

        [NameInMap("AppsRepeatList")]
        [Validation(Required=false)]
        public List<string> AppsRepeatList { get; set; }

        [NameInMap("ExecutorListRepeatList")]
        [Validation(Required=false)]
        public List<string> ExecutorListRepeatList { get; set; }

        [NameInMap("PubSeqListRepeatList")]
        [Validation(Required=false)]
        public List<string> PubSeqListRepeatList { get; set; }

    }

}

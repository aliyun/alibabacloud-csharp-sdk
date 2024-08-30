// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaConfig : TeaModel {
        [NameInMap("ACS")]
        [Validation(Required=false)]
        public ACS ACS { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DefaultGPUDriver")]
        [Validation(Required=false)]
        public string DefaultGPUDriver { get; set; }

        [NameInMap("EnablePreemptSubquotaWorkloads")]
        [Validation(Required=false)]
        public bool? EnablePreemptSubquotaWorkloads { get; set; }

        [NameInMap("ResourceSpecs")]
        [Validation(Required=false)]
        public List<WorkspaceSpecs> ResourceSpecs { get; set; }

        [NameInMap("SupportGPUDrivers")]
        [Validation(Required=false)]
        public List<string> SupportGPUDrivers { get; set; }

        [NameInMap("SupportRDMA")]
        [Validation(Required=false)]
        public bool? SupportRDMA { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

    }

}

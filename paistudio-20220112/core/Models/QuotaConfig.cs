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

        /// <summary>
        /// <b>Example:</b>
        /// <para>ceeb37xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ControlPlaneClusterId")]
        [Validation(Required=false)]
        public string ControlPlaneClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>470.199.02</para>
        /// </summary>
        [NameInMap("DefaultGPUDriver")]
        [Validation(Required=false)]
        public string DefaultGPUDriver { get; set; }

        [NameInMap("EnableGPUShare")]
        [Validation(Required=false)]
        public bool? EnableGPUShare { get; set; }

        [NameInMap("EnablePreemptSubquotaWorkloads")]
        [Validation(Required=false)]
        public bool? EnablePreemptSubquotaWorkloads { get; set; }

        [NameInMap("EnableSelfQuotaPreemption")]
        [Validation(Required=false)]
        public bool? EnableSelfQuotaPreemption { get; set; }

        [NameInMap("EnableSubQuotaPreemption")]
        [Validation(Required=false)]
        public bool? EnableSubQuotaPreemption { get; set; }

        [NameInMap("EniCacheConfig")]
        [Validation(Required=false)]
        public EniCacheConfig EniCacheConfig { get; set; }

        [NameInMap("OversoldUsageConfig")]
        [Validation(Required=false)]
        public OversoldUsageConfig OversoldUsageConfig { get; set; }

        [NameInMap("ResourceSpecs")]
        [Validation(Required=false)]
        public List<WorkspaceSpecs> ResourceSpecs { get; set; }

        [NameInMap("SandboxCacheConfig")]
        [Validation(Required=false)]
        public SandboxCacheConfig SandboxCacheConfig { get; set; }

        [NameInMap("SelfQuotaPreemptionConfig")]
        [Validation(Required=false)]
        public SelfQuotaPreemptionConfig SelfQuotaPreemptionConfig { get; set; }

        [NameInMap("SubQuotaPreemptionConfig")]
        [Validation(Required=false)]
        public SubQuotaPreemptionConfig SubQuotaPreemptionConfig { get; set; }

        [NameInMap("SupportGPUDrivers")]
        [Validation(Required=false)]
        public List<string> SupportGPUDrivers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportRDMA")]
        [Validation(Required=false)]
        public bool? SupportRDMA { get; set; }

        [NameInMap("UseCase")]
        [Validation(Required=false)]
        public string UseCase { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

    }

}

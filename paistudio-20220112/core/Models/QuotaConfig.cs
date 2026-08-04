// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaConfig : TeaModel {
        /// <summary>
        /// <para>The ACS-related configurations.</para>
        /// </summary>
        [NameInMap("ACS")]
        [Validation(Required=false)]
        public ACS ACS { get; set; }

        /// <summary>
        /// <para>The ID of the cluster where the quota resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ceeb3724255364***</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ControlPlaneClusterId")]
        [Validation(Required=false)]
        public string ControlPlaneClusterId { get; set; }

        /// <summary>
        /// <para>The default GPU driver version for the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>470.199.02</para>
        /// </summary>
        [NameInMap("DefaultGPUDriver")]
        [Validation(Required=false)]
        public string DefaultGPUDriver { get; set; }

        [NameInMap("EnableGPUShare")]
        [Validation(Required=false)]
        public bool? EnableGPUShare { get; set; }

        /// <summary>
        /// <para>Specifies whether workloads in sub-quotas can be preempted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePreemptSubquotaWorkloads")]
        [Validation(Required=false)]
        public bool? EnablePreemptSubquotaWorkloads { get; set; }

        /// <summary>
        /// <para>Specifies whether guaranteed resources within this quota can be preempted.</para>
        /// </summary>
        [NameInMap("EnableSelfQuotaPreemption")]
        [Validation(Required=false)]
        public bool? EnableSelfQuotaPreemption { get; set; }

        /// <summary>
        /// <para>Specifies whether resources in sub-quotas can be preempted.</para>
        /// </summary>
        [NameInMap("EnableSubQuotaPreemption")]
        [Validation(Required=false)]
        public bool? EnableSubQuotaPreemption { get; set; }

        [NameInMap("EniCacheConfig")]
        [Validation(Required=false)]
        public EniCacheConfig EniCacheConfig { get; set; }

        [NameInMap("IsEncryptedResource")]
        [Validation(Required=false)]
        public bool? IsEncryptedResource { get; set; }

        [NameInMap("OversoldUsageConfig")]
        [Validation(Required=false)]
        public OversoldUsageConfig OversoldUsageConfig { get; set; }

        /// <summary>
        /// <para>The resource specification templates.</para>
        /// </summary>
        [NameInMap("ResourceSpecs")]
        [Validation(Required=false)]
        public List<WorkspaceSpecs> ResourceSpecs { get; set; }

        [NameInMap("SandboxCacheConfig")]
        [Validation(Required=false)]
        public SandboxCacheConfig SandboxCacheConfig { get; set; }

        [NameInMap("SelfQuotaPreemptionConfig")]
        [Validation(Required=false)]
        public SelfQuotaPreemptionConfig SelfQuotaPreemptionConfig { get; set; }

        /// <summary>
        /// <para>The configuration for the sub-quota preemption task.</para>
        /// </summary>
        [NameInMap("SubQuotaPreemptionConfig")]
        [Validation(Required=false)]
        public SubQuotaPreemptionConfig SubQuotaPreemptionConfig { get; set; }

        /// <summary>
        /// <para>The GPU driver versions supported by the resource quota.</para>
        /// </summary>
        [NameInMap("SupportGPUDrivers")]
        [Validation(Required=false)]
        public List<string> SupportGPUDrivers { get; set; }

        /// <summary>
        /// <para>Specifies whether RDMA is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportRDMA")]
        [Validation(Required=false)]
        public bool? SupportRDMA { get; set; }

        [NameInMap("UseCase")]
        [Validation(Required=false)]
        public string UseCase { get; set; }

        /// <summary>
        /// <para>The user VPC information.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

        [NameInMap("WorkloadTypes")]
        [Validation(Required=false)]
        public List<string> WorkloadTypes { get; set; }

    }

}

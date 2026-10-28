// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaConfig : TeaModel {
        /// <summary>
        /// <para>The ACS-related configuration.</para>
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

        /// <summary>
        /// <para>The ID of the control plane cluster.</para>
        /// </summary>
        [NameInMap("ControlPlaneClusterId")]
        [Validation(Required=false)]
        public string ControlPlaneClusterId { get; set; }

        /// <summary>
        /// <para>The default driver version of the resource quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>470.199.02</para>
        /// </summary>
        [NameInMap("DefaultGPUDriver")]
        [Validation(Required=false)]
        public string DefaultGPUDriver { get; set; }

        /// <summary>
        /// <para>Specifies whether GPU sharing is enabled.</para>
        /// </summary>
        [NameInMap("EnableGPUShare")]
        [Validation(Required=false)]
        public bool? EnableGPUShare { get; set; }

        /// <summary>
        /// <para>Specifies whether sub-quota resources can be preempted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePreemptSubquotaWorkloads")]
        [Validation(Required=false)]
        public bool? EnablePreemptSubquotaWorkloads { get; set; }

        /// <summary>
        /// <para>Specifies whether guaranteed resource preemption for the current quota is enabled.</para>
        /// </summary>
        [NameInMap("EnableSelfQuotaPreemption")]
        [Validation(Required=false)]
        public bool? EnableSelfQuotaPreemption { get; set; }

        /// <summary>
        /// <para>Specifies whether sub-quota resources can be preempted.</para>
        /// </summary>
        [NameInMap("EnableSubQuotaPreemption")]
        [Validation(Required=false)]
        public bool? EnableSubQuotaPreemption { get; set; }

        /// <summary>
        /// <para>The elastic network interface controller (NIC) cache configuration.</para>
        /// </summary>
        [NameInMap("EniCacheConfig")]
        [Validation(Required=false)]
        public EniCacheConfig EniCacheConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether the resource is encrypted.</para>
        /// </summary>
        [NameInMap("IsEncryptedResource")]
        [Validation(Required=false)]
        public bool? IsEncryptedResource { get; set; }

        /// <summary>
        /// <para>The off-peak resource usage configuration.</para>
        /// </summary>
        [NameInMap("OversoldUsageConfig")]
        [Validation(Required=false)]
        public OversoldUsageConfig OversoldUsageConfig { get; set; }

        /// <summary>
        /// <para>The resource specification template.</para>
        /// </summary>
        [NameInMap("ResourceSpecs")]
        [Validation(Required=false)]
        public List<WorkspaceSpecs> ResourceSpecs { get; set; }

        /// <summary>
        /// <para>The sandbox cache configuration.</para>
        /// </summary>
        [NameInMap("SandboxCacheConfig")]
        [Validation(Required=false)]
        public SandboxCacheConfig SandboxCacheConfig { get; set; }

        /// <summary>
        /// <para>The self-quota preemption configuration.</para>
        /// </summary>
        [NameInMap("SelfQuotaPreemptionConfig")]
        [Validation(Required=false)]
        public SelfQuotaPreemptionConfig SelfQuotaPreemptionConfig { get; set; }

        /// <summary>
        /// <para>The sub-quota task preemption configuration.</para>
        /// </summary>
        [NameInMap("SubQuotaPreemptionConfig")]
        [Validation(Required=false)]
        public SubQuotaPreemptionConfig SubQuotaPreemptionConfig { get; set; }

        /// <summary>
        /// <para>The driver versions supported by the resource quota.</para>
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

        /// <summary>
        /// <para>The scenarios of the resource quota.</para>
        /// </summary>
        [NameInMap("UseCase")]
        [Validation(Required=false)]
        public string UseCase { get; set; }

        /// <summary>
        /// <para>The user VPC information.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

        /// <summary>
        /// <para>The workload types supported by the quota.</para>
        /// </summary>
        [NameInMap("WorkloadTypes")]
        [Validation(Required=false)]
        public List<string> WorkloadTypes { get; set; }

    }

}

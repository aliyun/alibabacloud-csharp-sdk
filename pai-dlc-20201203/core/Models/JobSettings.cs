// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSettings : TeaModel {
        /// <summary>
        /// <para>The additional advanced parameter settings.</para>
        /// </summary>
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedSettings { get; set; }

        /// <summary>
        /// <para>Specifies whether to allocate all RDMA NICs.</para>
        /// </summary>
        [NameInMap("AllocateAllRDMADevices")]
        [Validation(Required=false)]
        public bool? AllocateAllRDMADevices { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow jobs to be scheduled to nodes that are marked as unschedulable or are in the workspace blacklist. If enabled, node status checks are skipped and the corresponding bypass configurations are applied.</para>
        /// </summary>
        [NameInMap("AllowUnschedulableNodes")]
        [Validation(Required=false)]
        public bool? AllowUnschedulableNodes { get; set; }

        /// <summary>
        /// <para>The ID of the user associated with the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16****</para>
        /// </summary>
        [NameInMap("BusinessUserId")]
        [Validation(Required=false)]
        public string BusinessUserId { get; set; }

        /// <summary>
        /// <para>The caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SilkFlow</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>The DataJuicer job configuration.</para>
        /// </summary>
        [NameInMap("DataJuicerConfig")]
        [Validation(Required=false)]
        public DataJuicerConfig DataJuicerConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the ECS inventory check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableEcsStockCheck")]
        [Validation(Required=false)]
        public bool? DisableEcsStockCheck { get; set; }

        /// <summary>
        /// <para>The NVIDIA driver configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>535.54.03</para>
        /// </summary>
        [NameInMap("Driver")]
        [Validation(Required=false)]
        public string Driver { get; set; }

        /// <summary>
        /// <para>The maximum number of restarts for an elastic spot job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ElasticSpotJobMaxRestartTimes")]
        [Validation(Required=false)]
        public int? ElasticSpotJobMaxRestartTimes { get; set; }

        /// <summary>
        /// <para>The CPU affinity settings. These settings take effect only when general-purpose computing subscription resources are used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCPUAffinity")]
        [Validation(Required=false)]
        public bool? EnableCPUAffinity { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the DSW development mode for the job. If enabled, a sidecar container is injected into the pod.</para>
        /// </summary>
        [NameInMap("EnableDSWDev")]
        [Validation(Required=false)]
        public bool? EnableDSWDev { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable fault tolerance monitoring for the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableErrorMonitoringInAIMaster")]
        [Validation(Required=false)]
        public bool? EnableErrorMonitoringInAIMaster { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow OSS append writes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableOssAppend")]
        [Validation(Required=false)]
        public bool? EnableOssAppend { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the job to use RDMA. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRDMA")]
        [Validation(Required=false)]
        public bool? EnableRDMA { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable computing power health checks for the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSanityCheck")]
        [Validation(Required=false)]
        public bool? EnableSanityCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the job to use tide resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTideResource")]
        [Validation(Required=false)]
        public bool? EnableTideResource { get; set; }

        /// <summary>
        /// <para>The configuration parameters for fault tolerance monitoring when it is enabled, such as specifying whether to enable log hang-based detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--enable-log-hang-detection true</para>
        /// </summary>
        [NameInMap("ErrorMonitoringArgs")]
        [Validation(Required=false)]
        public string ErrorMonitoringArgs { get; set; }

        /// <summary>
        /// <para>The retention duration after the job ends, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("JobReservedMinutes")]
        [Validation(Required=false)]
        public int? JobReservedMinutes { get; set; }

        /// <summary>
        /// <para>The retention policy after the job ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Always</para>
        /// </summary>
        [NameInMap("JobReservedPolicy")]
        [Validation(Required=false)]
        public string JobReservedPolicy { get; set; }

        /// <summary>
        /// <para>The output model configuration. This parameter takes effect only in joint training scenarios.</para>
        /// </summary>
        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public ModelConfig ModelConfig { get; set; }

        /// <summary>
        /// <para>The oversold resource usage mode for the job, which can be not accepted, accepted, or only accepted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AcceptQuotaOverSold</para>
        /// </summary>
        [NameInMap("OversoldType")]
        [Validation(Required=false)]
        public string OversoldType { get; set; }

        /// <summary>
        /// <para>The workflow ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pid-12****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The configuration parameters for computing power health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--sanity-check-timing=AfterJobFaultTolerant --sanity-check-timeout-ops=MarkJobFail</para>
        /// </summary>
        [NameInMap("SanityCheckArgs")]
        [Validation(Required=false)]
        public string SanityCheckArgs { get; set; }

        /// <summary>
        /// <para>The shell used to execute job commands. Valid values: /bin/sh and /bin/bash.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/bin/bash</para>
        /// </summary>
        [NameInMap("Shell")]
        [Validation(Required=false)]
        public string Shell { get; set; }

        /// <summary>
        /// <para>The custom tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>The grace period to wait for the pod to exit when the job is terminated, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

    }

}

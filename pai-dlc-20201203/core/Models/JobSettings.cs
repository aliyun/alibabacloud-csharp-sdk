// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSettings : TeaModel {
        /// <summary>
        /// <para>The extra advanced parameter settings.</para>
        /// </summary>
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedSettings { get; set; }

        /// <summary>
        /// <para>Specifies whether to mount all RDMA network interfaces.</para>
        /// </summary>
        [NameInMap("AllocateAllRDMADevices")]
        [Validation(Required=false)]
        public bool? AllocateAllRDMADevices { get; set; }

        [NameInMap("AllowUnschedulableNodes")]
        [Validation(Required=false)]
        public bool? AllowUnschedulableNodes { get; set; }

        /// <summary>
        /// <para>The user ID associated with the job.</para>
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
        /// <para>The DataJuicer task configuration.</para>
        /// </summary>
        [NameInMap("DataJuicerConfig")]
        [Validation(Required=false)]
        public DataJuicerConfig DataJuicerConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip inventory check. Valid values:</para>
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

        [NameInMap("ElasticSpotJobMaxRestartTimes")]
        [Validation(Required=false)]
        public int? ElasticSpotJobMaxRestartTimes { get; set; }

        /// <summary>
        /// <para>The CPU affinity setting. This setting is effective only when using general computing subscription resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCPUAffinity")]
        [Validation(Required=false)]
        public bool? EnableCPUAffinity { get; set; }

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
        /// <para>Specifies whether to allow OSS append write. Valid values:</para>
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
        /// <para>Specifies whether to enable computing power health check for the job. Valid values:</para>
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
        /// <para>Specifies whether to allow the job to use tidal resources. Valid values:</para>
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
        /// <para>The configuration parameters for fault tolerance monitoring after it is enabled, such as whether to enable log hang-based detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--enable-log-hang-detection true</para>
        /// </summary>
        [NameInMap("ErrorMonitoringArgs")]
        [Validation(Required=false)]
        public string ErrorMonitoringArgs { get; set; }

        /// <summary>
        /// <para>The retention duration after job completion, in minutes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("JobReservedMinutes")]
        [Validation(Required=false)]
        public int? JobReservedMinutes { get; set; }

        /// <summary>
        /// <para>The retention policy after job completion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Always</para>
        /// </summary>
        [NameInMap("JobReservedPolicy")]
        [Validation(Required=false)]
        public string JobReservedPolicy { get; set; }

        /// <summary>
        /// <para>The output model configuration. This parameter is currently effective only in joint training scenarios.</para>
        /// </summary>
        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public ModelConfig ModelConfig { get; set; }

        /// <summary>
        /// <para>The oversold resource usage mode for the job (reject/accept/only accept).</para>
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
        /// <para>The configuration parameters for computing power health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--sanity-check-timing=AfterJobFaultTolerant --sanity-check-timeout-ops=MarkJobFail</para>
        /// </summary>
        [NameInMap("SanityCheckArgs")]
        [Validation(Required=false)]
        public string SanityCheckArgs { get; set; }

        /// <summary>
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

        [NameInMap("TerminationGracePeriodSeconds")]
        [Validation(Required=false)]
        public long? TerminationGracePeriodSeconds { get; set; }

    }

}

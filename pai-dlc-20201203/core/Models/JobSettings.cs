// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSettings : TeaModel {
        /// <summary>
        /// <para>The additional advanced parameter configurations.</para>
        /// </summary>
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedSettings { get; set; }

        /// <summary>
        /// <para>Whether to mount all RDMA network interface controllers</para>
        /// </summary>
        [NameInMap("AllocateAllRDMADevices")]
        [Validation(Required=false)]
        public bool? AllocateAllRDMADevices { get; set; }

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

        [NameInMap("DataJuicerConfig")]
        [Validation(Required=false)]
        public DataJuicerConfig DataJuicerConfig { get; set; }

        /// <summary>
        /// <para>Whether inventory check is skipped. Valid values:</para>
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
        /// <para>The NVIDIA driver configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>535.54.03</para>
        /// </summary>
        [NameInMap("Driver")]
        [Validation(Required=false)]
        public string Driver { get; set; }

        /// <summary>
        /// <para>Whether the CPU affinity is enabled. This parameter takes effect only when you use subscription general computing resources.</para>
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
        /// <para>Whether fault tolerance monitoring is enabled for the job. Valid values:</para>
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
        /// <para>Whether data is written to Object Storage Service (OSS) in append mode. Valid values:</para>
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
        /// <para>Whether RDMA is enabled for the job. Valid values:</para>
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
        /// <para>Whether sanity check is enabled for the job. Valid values:</para>
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
        /// <para>Whether tidal resources are allowed for the job. Valid values:</para>
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
        /// <para>The configuration parameters after you enable fault tolerance monitoring. For example, you can specify whether to enable log hang-based detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--enable-log-hang-detection true</para>
        /// </summary>
        [NameInMap("ErrorMonitoringArgs")]
        [Validation(Required=false)]
        public string ErrorMonitoringArgs { get; set; }

        /// <summary>
        /// <para>The retention period after the job ends. Unit: minutes.</para>
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

        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public ModelConfig ModelConfig { get; set; }

        /// <summary>
        /// <para>Whether the job accepts oversold resources. Valid values: ForbiddenQuotaOverSold, AcceptQuotaOverSold, and ForceQuotaOverSold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AcceptQuotaOverSold</para>
        /// </summary>
        [NameInMap("OversoldType")]
        [Validation(Required=false)]
        public string OversoldType { get; set; }

        /// <summary>
        /// <para>The pipeline ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pid-123456</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The configuration parameters for sanity check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>--sanity-check-timing=AfterJobFaultTolerant --sanity-check-timeout-ops=MarkJobFail</para>
        /// </summary>
        [NameInMap("SanityCheckArgs")]
        [Validation(Required=false)]
        public string SanityCheckArgs { get; set; }

        /// <summary>
        /// <para>The custom tag.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

    }

}

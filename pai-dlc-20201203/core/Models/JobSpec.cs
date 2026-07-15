// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSpec : TeaModel {
        /// <summary>
        /// <para>The scheduling node assignment configuration.</para>
        /// </summary>
        [NameInMap("AssignNodeSpec")]
        [Validation(Required=false)]
        public AssignNodeSpec AssignNodeSpec { get; set; }

        /// <summary>
        /// <para>The auto scaling configuration.</para>
        /// </summary>
        [NameInMap("AutoScalingSpec")]
        [Validation(Required=false)]
        public AutoScalingSpec AutoScalingSpec { get; set; }

        /// <summary>
        /// <para>Specifies whether to consider this role when determining job success. This parameter takes effect only when the success policy is set to Partial.</para>
        /// </summary>
        [NameInMap("ConsiderInSuccessPolicy")]
        [Validation(Required=false)]
        public bool? ConsiderInSuccessPolicy { get; set; }

        /// <summary>
        /// <para>The hardware specifications of the worker. Visit <a href="https://help.aliyun.com/document_detail/171758.html">PAI-DLC billing</a> for the detailed list of specifications.&gt;Notice: Prices vary depending on the specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        [NameInMap("ElasticSpotSpecs")]
        [Validation(Required=false)]
        public List<ElasticSpotSpec> ElasticSpotSpecs { get; set; }

        /// <summary>
        /// <para>The additional pod configuration.</para>
        /// </summary>
        [NameInMap("ExtraPodSpec")]
        [Validation(Required=false)]
        public ExtraPodSpec ExtraPodSpec { get; set; }

        [NameInMap("HyperNodeSchedulingConfig")]
        [Validation(Required=false)]
        public HyperNodeSchedulingConfig HyperNodeSchedulingConfig { get; set; }

        /// <summary>
        /// <para>The runtime image address for this type of worker. Call <a href="https://help.aliyun.com/document_detail/449118.html">ListImages</a> to obtain images provided by the PAI platform. You can also specify a third-party public image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/cloud-dsw/tensorflow:1.12PAI-gpu-py36-cu101-ubuntu18.04</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The private image configuration.</para>
        /// </summary>
        [NameInMap("ImageConfig")]
        [Validation(Required=false)]
        public ImageConfig ImageConfig { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated due to a spelling error.</para>
        /// </summary>
        [NameInMap("IsCheif")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? IsCheif { get; set; }

        /// <summary>
        /// <para>Indicates whether this role is the Chief role. Only one Chief role is allowed.</para>
        /// </summary>
        [NameInMap("IsChief")]
        [Validation(Required=false)]
        public bool? IsChief { get; set; }

        /// <summary>
        /// <para>The list of local mount configurations.</para>
        /// </summary>
        [NameInMap("LocalMountSpecs")]
        [Validation(Required=false)]
        public List<LocalMountSpec> LocalMountSpecs { get; set; }

        [NameInMap("OversoldType")]
        [Validation(Required=false)]
        public string OversoldType { get; set; }

        /// <summary>
        /// <para>The number of replicas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PodCount")]
        [Validation(Required=false)]
        public long? PodCount { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The resource configuration.</para>
        /// </summary>
        [NameInMap("ResourceConfig")]
        [Validation(Required=false)]
        public ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// <para>The restart policy. Valid values: Always, Never, OnFailure, and ExitCode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExitCode</para>
        /// </summary>
        [NameInMap("RestartPolicy")]
        [Validation(Required=false)]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// <para>The service configuration.</para>
        /// </summary>
        [NameInMap("ServiceSpec")]
        [Validation(Required=false)]
        public ServiceSpec ServiceSpec { get; set; }

        /// <summary>
        /// <para>The spot instance configuration.</para>
        /// </summary>
        [NameInMap("SpotSpec")]
        [Validation(Required=false)]
        public SpotSpec SpotSpec { get; set; }

        /// <summary>
        /// <para>The dependencies required before this role starts.</para>
        /// </summary>
        [NameInMap("StartupDependencies")]
        [Validation(Required=false)]
        public List<StartupDependency> StartupDependencies { get; set; }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDisk SystemDisk { get; set; }

        /// <summary>
        /// <para>Type is closely related to Job Type. Different Job Types support different Worker Types.</para>
        /// <list type="bullet">
        /// <item><description><para><b>TFJob</b>: Supports Chief, PS, Worker, Evaluator, and GraphLearn.</para>
        /// </description></item>
        /// <item><description><para><b>PyTorchJob</b>: Supports Worker and Master.</para>
        /// </description></item>
        /// <item><description><para><b>XGBoostJob</b>: Supports Worker and Master.</para>
        /// </description></item>
        /// <item><description><para><b>OneFlowJob</b>: Supports Worker and Master.</para>
        /// </description></item>
        /// <item><description><para><b>ElasticBatch</b>: Supports Worker and Master.</para>
        /// </description></item>
        /// <item><description><para><b>RayJob</b>: Supports Head, Worker, and Worker[-xxx].</para>
        /// </description></item>
        /// </list>
        /// <para>Master is optional in PyTorchJob, XGBoostJob, OneFlowJob, and ElasticBatch. If Master is not specified, the system automatically designates the first Worker node as Master.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Worker</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether to use spot instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseSpotInstance")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? UseSpotInstance { get; set; }

    }

}

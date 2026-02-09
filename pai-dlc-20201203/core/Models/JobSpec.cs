// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSpec : TeaModel {
        /// <summary>
        /// <para>The scheduling node configurations.</para>
        /// </summary>
        [NameInMap("AssignNodeSpec")]
        [Validation(Required=false)]
        public AssignNodeSpec AssignNodeSpec { get; set; }

        /// <summary>
        /// <para>The auto scaling configurations.</para>
        /// </summary>
        [NameInMap("AutoScalingSpec")]
        [Validation(Required=false)]
        public AutoScalingSpec AutoScalingSpec { get; set; }

        /// <summary>
        /// <para>The hardware specifications of the worker. For more information, see <a href="https://help.aliyun.com/document_detail/171758.html">Billing of DLC</a> of PAI.</para>
        /// <remarks>
        /// <para> The price varies based on instance types.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// <para>The additional pod configurations.</para>
        /// </summary>
        [NameInMap("ExtraPodSpec")]
        [Validation(Required=false)]
        public ExtraPodSpec ExtraPodSpec { get; set; }

        /// <summary>
        /// <para>The address of the image that is run by the worker node. You can call <a href="https://help.aliyun.com/document_detail/449118.html">ListImages</a> to obtain the image provided by PAI. You can also specify a third-party public image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/cloud-dsw/tensorflow:1.12PAI-gpu-py36-cu101-ubuntu18.04</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The configuration of the private image.</para>
        /// </summary>
        [NameInMap("ImageConfig")]
        [Validation(Required=false)]
        public ImageConfig ImageConfig { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Deprecated.</para>
        /// </summary>
        [NameInMap("IsCheif")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? IsCheif { get; set; }

        /// <summary>
        /// <para>Whether the role is a Chief role. Chief role must be unique.</para>
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

        /// <summary>
        /// <para>The number of replicas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PodCount")]
        [Validation(Required=false)]
        public long? PodCount { get; set; }

        /// <summary>
        /// <para>The resource configurations.</para>
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
        /// <para>The service configurations.</para>
        /// </summary>
        [NameInMap("ServiceSpec")]
        [Validation(Required=false)]
        public ServiceSpec ServiceSpec { get; set; }

        /// <summary>
        /// <para>The configurations of the preemptible instance.</para>
        /// </summary>
        [NameInMap("SpotSpec")]
        [Validation(Required=false)]
        public SpotSpec SpotSpec { get; set; }

        [NameInMap("StartupDependencies")]
        [Validation(Required=false)]
        public List<StartupDependency> StartupDependencies { get; set; }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDisk SystemDisk { get; set; }

        /// <summary>
        /// <para>The worker type, which is related to JobType. The valid values of this parameter vary based on the value of JobType.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when JobType is set to <b>TFJob</b>: Chief, PS, Worker, Evaluator, and GraphLearn.</description></item>
        /// <item><description>Valid values when JobType is set to <b>PyTorchJob</b>: Worker and Master.</description></item>
        /// <item><description>Valid values when JobType is set to <b>XGBoostJob</b>: Worker and Master.</description></item>
        /// <item><description>Valid values when JobType is set to <b>OneFlowJob</b>: Worker and Master.</description></item>
        /// <item><description>Valid values when JobType is set to <b>ElasticBatch</b>: Worker and Master.</description></item>
        /// </list>
        /// <para>The Master node in jobs of the PyTorchJob, XGBoostJob, OneFlowJob, or ElasticBatch type is optional. If you do not specify the Master node, the system automatically uses the first Worker node as the Master node.</para>
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
        /// <para>Whether to use preemptible instances.</para>
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

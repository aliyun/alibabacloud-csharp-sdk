// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("AccumulatedRunningTimeInMs")]
        [Validation(Required=false)]
        public long? AccumulatedRunningTimeInMs { get; set; }

        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyAffinity Affinity { get; set; }
        public class GetInstanceResponseBodyAffinity : TeaModel {
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyAffinityCPU CPU { get; set; }
            public class GetInstanceResponseBodyAffinityCPU : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

        }

        [NameInMap("CloudDisks")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyCloudDisks> CloudDisks { get; set; }
        public class GetInstanceResponseBodyCloudDisks : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyDatasets> Datasets { get; set; }
        public class GetInstanceResponseBodyDatasets : TeaModel {
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            [NameInMap("OptionType")]
            [Validation(Required=false)]
            public string OptionType { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("Driver")]
        [Validation(Required=false)]
        public string Driver { get; set; }

        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("IdleInstanceCuller")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyIdleInstanceCuller IdleInstanceCuller { get; set; }
        public class GetInstanceResponseBodyIdleInstanceCuller : TeaModel {
            [NameInMap("CpuPercentThreshold")]
            [Validation(Required=false)]
            public int? CpuPercentThreshold { get; set; }

            [NameInMap("GpuPercentThreshold")]
            [Validation(Required=false)]
            public int? GpuPercentThreshold { get; set; }

            [NameInMap("IdleTimeInMinutes")]
            [Validation(Required=false)]
            public int? IdleTimeInMinutes { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("MaxIdleTimeInMinutes")]
            [Validation(Required=false)]
            public int? MaxIdleTimeInMinutes { get; set; }

        }

        [NameInMap("ImageAuth")]
        [Validation(Required=false)]
        public string ImageAuth { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("InstanceShutdownTimer")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstanceShutdownTimer InstanceShutdownTimer { get; set; }
        public class GetInstanceResponseBodyInstanceShutdownTimer : TeaModel {
            [NameInMap("DueTime")]
            [Validation(Required=false)]
            public string DueTime { get; set; }

            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("RemainingTimeInMs")]
            [Validation(Required=false)]
            public long? RemainingTimeInMs { get; set; }

        }

        [NameInMap("InstanceSnapshotList")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyInstanceSnapshotList> InstanceSnapshotList { get; set; }
        public class GetInstanceResponseBodyInstanceSnapshotList : TeaModel {
            /// <summary>
            /// 快照创建时间
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// 快照修改时间
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// 镜像Id
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// 镜像名称
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// 镜像Url
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// 实例快照错误代码
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// 实例快照错误消息
            /// </summary>
            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// 镜像仓库Url
            /// </summary>
            [NameInMap("RepositoryUrl")]
            [Validation(Required=false)]
            public string RepositoryUrl { get; set; }

            /// <summary>
            /// 实例快照状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("InstanceUrl")]
        [Validation(Required=false)]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// Jupyterlab Url。
        /// </summary>
        [NameInMap("JupyterlabUrl")]
        [Validation(Required=false)]
        public string JupyterlabUrl { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyLabels> Labels { get; set; }
        public class GetInstanceResponseBodyLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("LatestSnapshot")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyLatestSnapshot LatestSnapshot { get; set; }
        public class GetInstanceResponseBodyLatestSnapshot : TeaModel {
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// 实例快照错误代码
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// 实例快照错误消息
            /// </summary>
            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            [NameInMap("RepositoryUrl")]
            [Validation(Required=false)]
            public string RepositoryUrl { get; set; }

            /// <summary>
            /// 实例快照状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NodeErrorRecovery")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyNodeErrorRecovery NodeErrorRecovery { get; set; }
        public class GetInstanceResponseBodyNodeErrorRecovery : TeaModel {
            [NameInMap("autoSwitchCountdownSeconds")]
            [Validation(Required=false)]
            public long? AutoSwitchCountdownSeconds { get; set; }

            [NameInMap("enableAutoSwitchOnNodeError")]
            [Validation(Required=false)]
            public bool? EnableAutoSwitchOnNodeError { get; set; }

            [NameInMap("hasNodeError")]
            [Validation(Required=false)]
            public bool? HasNodeError { get; set; }

        }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestedResource")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyRequestedResource RequestedResource { get; set; }
        public class GetInstanceResponseBodyRequestedResource : TeaModel {
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public string CPU { get; set; }

            [NameInMap("GPU")]
            [Validation(Required=false)]
            public string GPU { get; set; }

            [NameInMap("GPUType")]
            [Validation(Required=false)]
            public string GPUType { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            [NameInMap("SharedMemory")]
            [Validation(Required=false)]
            public string SharedMemory { get; set; }

        }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TerminalUrl")]
        [Validation(Required=false)]
        public string TerminalUrl { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyUserVpc UserVpc { get; set; }
        public class GetInstanceResponseBodyUserVpc : TeaModel {
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            [NameInMap("ForwardInfos")]
            [Validation(Required=false)]
            public List<ForwardInfoResponse> ForwardInfos { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// Vpc Id。
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// Web IDE url。
        /// </summary>
        [NameInMap("WebIDEUrl")]
        [Validation(Required=false)]
        public string WebIDEUrl { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

        [NameInMap("WorkspaceSource")]
        [Validation(Required=false)]
        public string WorkspaceSource { get; set; }

    }

}

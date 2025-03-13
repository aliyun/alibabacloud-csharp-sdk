// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600000</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CloudDisks")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyCloudDisks> CloudDisks { get; set; }
        public class GetInstanceResponseBodyCloudDisks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30Gi</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/mmt/workspace</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/workspace</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rootfs</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>d-vsqjvsjp4orp5l206u</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            [NameInMap("DatasetVersion")]
            [Validation(Required=false)]
            public string DatasetVersion { get; set; }

            [NameInMap("MountAccess")]
            [Validation(Required=false)]
            public string MountAccess { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/mnt/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            [NameInMap("OptionType")]
            [Validation(Required=false)]
            public string OptionType { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://bucket.oss-cn-shanghai.aliyuncs.com/data/path/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>535.54.03</para>
        /// </summary>
        [NameInMap("Driver")]
        [Validation(Required=false)]
        public string Driver { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{userName: &quot;Chris&quot;}</para>
        /// </summary>
        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;InstanceId&quot;:&quot;dsw-05cefd0be2e5a278&quot;,&quot;CpuPercentThreshold&quot;:20,&quot;GpuPercentThreshold&quot;:10,&quot;MaxIdleTimeInMinutes&quot;:120,&quot;IdleTimeInMinutes&quot;:30}</para>
        /// </summary>
        [NameInMap("IdleInstanceCuller")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyIdleInstanceCuller IdleInstanceCuller { get; set; }
        public class GetInstanceResponseBodyIdleInstanceCuller : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("CpuPercentThreshold")]
            [Validation(Required=false)]
            public int? CpuPercentThreshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("GpuPercentThreshold")]
            [Validation(Required=false)]
            public int? GpuPercentThreshold { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("IdleTimeInMinutes")]
            [Validation(Required=false)]
            public int? IdleTimeInMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dsw-730xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("MaxIdleTimeInMinutes")]
            [Validation(Required=false)]
            public int? MaxIdleTimeInMinutes { get; set; }

        }

        [NameInMap("ImageAuth")]
        [Validation(Required=false)]
        public string ImageAuth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>image-05cefd0be2exxxx</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>py36_cpu_tf1.12_ubuntu</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/pai_product/tensorflow:py36_cpu_tf1.12_ubuntu</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dsw-730xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>training_data</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("InstanceShutdownTimer")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstanceShutdownTimer InstanceShutdownTimer { get; set; }
        public class GetInstanceResponseBodyInstanceShutdownTimer : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("DueTime")]
            [Validation(Required=false)]
            public string DueTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dsw-730xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600000</para>
            /// </summary>
            [NameInMap("RemainingTimeInMs")]
            [Validation(Required=false)]
            public long? RemainingTimeInMs { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("InstanceSnapshotList")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyInstanceSnapshotList> InstanceSnapshotList { get; set; }
        public class GetInstanceResponseBodyInstanceSnapshotList : TeaModel {
            /// <summary>
            /// <para>快照创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>快照修改时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>镜像Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-05cefd0be2exxxx</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>镜像名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>py36_cpu_tf1.12_ubuntu</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>镜像Url</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry.cn-shanghai.aliyuncs.com/pai_product/tensorflow:py36_cpu_tf1.12_ubuntu</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>实例快照错误代码</para>
            /// 
            /// <b>Example:</b>
            /// <para>Internal Error</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>实例快照错误消息</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImagePullBackOff</para>
            /// </summary>
            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// <para>镜像仓库Url</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cr.console.aliyun.com/repository/cn-hangzhou/zouxu/kf/images">https://cr.console.aliyun.com/repository/cn-hangzhou/zouxu/kf/images</a></para>
            /// </summary>
            [NameInMap("RepositoryUrl")]
            [Validation(Required=false)]
            public string RepositoryUrl { get; set; }

            /// <summary>
            /// <para>实例快照状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pushing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://dsw-cn-shanghai.data.aliyun.com/notebook.htm?instance=39772#/">https://dsw-cn-shanghai.data.aliyun.com/notebook.htm?instance=39772#/</a></para>
        /// </summary>
        [NameInMap("InstanceUrl")]
        [Validation(Required=false)]
        public string InstanceUrl { get; set; }

        /// <summary>
        /// <para>Jupyterlab Url。</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/lab/">https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/lab/</a></para>
        /// </summary>
        [NameInMap("JupyterlabUrl")]
        [Validation(Required=false)]
        public string JupyterlabUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;foo\&quot;: \&quot;bar\&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyLabels> Labels { get; set; }
        public class GetInstanceResponseBodyLabels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>stsTokenOwner</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123xxxxxxxx</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("LatestSnapshot")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyLatestSnapshot LatestSnapshot { get; set; }
        public class GetInstanceResponseBodyLatestSnapshot : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>image-05cefd0be2exxxx</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>py36_cpu_tf1.12_ubuntu</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>registry.cn-shanghai.aliyuncs.com/pai_product/tensorflow:py36_cpu_tf1.12_ubuntu</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>实例快照错误代码</para>
            /// 
            /// <b>Example:</b>
            /// <para>Internal Error</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>实例快照错误消息</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImagePullBackOff</para>
            /// </summary>
            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://cr.console.aliyun.com/repository/cn-hangzhou/zouxu/kf/images">https://cr.console.aliyun.com/repository/cn-hangzhou/zouxu/kf/images</a></para>
            /// </summary>
            [NameInMap("RepositoryUrl")]
            [Validation(Required=false)]
            public string RepositoryUrl { get; set; }

            /// <summary>
            /// <para>实例快照状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pushing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;XXX&quot;</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("ProxyPath")]
        [Validation(Required=false)]
        public string ProxyPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Internal Error</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ImagePullBackOff</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E7D55162-4489-1619-AAF5-3F97D5FCA948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;CPU&quot;:&quot;4&quot;,&quot;Memory&quot;:&quot;8Gi&quot;,&quot;SharedMemory&quot;:&quot;4Gi&quot;,&quot;GPU&quot;:&quot;1&quot;,&quot;GPUType&quot;:&quot;Tesla-V100-16G&quot;}</para>
        /// </summary>
        [NameInMap("RequestedResource")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyRequestedResource RequestedResource { get; set; }
        public class GetInstanceResponseBodyRequestedResource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public string CPU { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public string GPU { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v100</para>
            /// </summary>
            [NameInMap("GPUType")]
            [Validation(Required=false)]
            public string GPUType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("SharedMemory")]
            [Validation(Required=false)]
            public string SharedMemory { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dsw-123456789</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs.g7.xlarge</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyTags> Tags { get; set; }
        public class GetInstanceResponseBodyTags : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/tty/">https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/tty/</a></para>
        /// </summary>
        [NameInMap("TerminalUrl")]
        [Validation(Required=false)]
        public string TerminalUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1612285282502324</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试用户</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyUserVpc UserVpc { get; set; }
        public class GetInstanceResponseBodyUserVpc : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>eth0 | eth1</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;192.168.0.1/24&quot;, &quot;192.168.1.1/24&quot;]</para>
            /// </summary>
            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            [NameInMap("ForwardInfos")]
            [Validation(Required=false)]
            public List<ForwardInfoResponse> ForwardInfos { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-xxxxxx</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-xxxxx</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>Vpc Id。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>Web IDE url。</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/ide/">https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/ide/</a></para>
        /// </summary>
        [NameInMap("WebIDEUrl")]
        [Validation(Required=false)]
        public string WebIDEUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40823</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>training_data</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d-123456789</para>
        /// </summary>
        [NameInMap("WorkspaceSource")]
        [Validation(Required=false)]
        public string WorkspaceSource { get; set; }

    }

}

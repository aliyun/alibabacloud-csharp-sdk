// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InternalError: an internal error. All errors, except for parameter validation errors, are classified as internal errors.</description></item>
        /// <item><description>ValidationError: a parameter validation error.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>400</description></item>
        /// <item><description>404</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The instances returned on this page.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The accelerator type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CPU</description></item>
            /// <item><description>GPU</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("AcceleratorType")]
            [Validation(Required=false)]
            public string AcceleratorType { get; set; }

            /// <summary>
            /// <para>The accessibility. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PRIVATE (default): The instances are accessible only to you and the administrator of the workspace.</description></item>
            /// <item><description>PUBLIC: The instances are accessible only to all members in the workspace.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE</para>
            /// </summary>
            [NameInMap("Accessibility")]
            [Validation(Required=false)]
            public string Accessibility { get; set; }

            /// <summary>
            /// <para>The accumulated running duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600000</para>
            /// </summary>
            [NameInMap("AccumulatedRunningTimeInMs")]
            [Validation(Required=false)]
            public long? AccumulatedRunningTimeInMs { get; set; }

            /// <summary>
            /// <para>The affinity configuration.</para>
            /// </summary>
            [NameInMap("Affinity")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesAffinity Affinity { get; set; }
            public class ListInstancesResponseBodyInstancesAffinity : TeaModel {
                /// <summary>
                /// <para>The CPU affinity configuration. Only subscription instances that use general-purpose computing resources support CPU affinity configuration.</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyInstancesAffinityCPU CPU { get; set; }
                public class ListInstancesResponseBodyInstancesAffinityCPU : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the CPU affinity feature was enabled.</para>
                    /// <para>true false</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                }

            }

            /// <summary>
            /// <para>The cloud disks of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("CloudDisks")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesCloudDisks> CloudDisks { get; set; }
            public class ListInstancesResponseBodyInstancesCloudDisks : TeaModel {
                /// <summary>
                /// <para>The cloud disk capacity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30Gi</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public string Capacity { get; set; }

                /// <summary>
                /// <para>The mount path of the cloud disk in the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mmt/workspace</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The directory on the cloud disk that is mounted to the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/workspace</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The cloud disk type. The value rootfs indicates that the cloud disk is used as the root file system (rootfs).</para>
                /// 
                /// <b>Example:</b>
                /// <para>rootfs</para>
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

            }

            /// <summary>
            /// <para>The credential configuration.</para>
            /// </summary>
            [NameInMap("CredentialConfig")]
            [Validation(Required=false)]
            public CredentialConfig CredentialConfig { get; set; }

            /// <summary>
            /// <para>The datasets.</para>
            /// </summary>
            [NameInMap("Datasets")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesDatasets> Datasets { get; set; }
            public class ListInstancesResponseBodyInstancesDatasets : TeaModel {
                /// <summary>
                /// <para>The dataset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-vsqjvsjp4orp5l206u</para>
                /// </summary>
                [NameInMap("DatasetId")]
                [Validation(Required=false)]
                public string DatasetId { get; set; }

                /// <summary>
                /// <para>The dataset version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("DatasetVersion")]
                [Validation(Required=false)]
                public string DatasetVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether dynamic mounting was enabled. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Dynamic")]
                [Validation(Required=false)]
                public bool? Dynamic { get; set; }

                /// <summary>
                /// <para>The read and write permissions. Valid values: RW and RO.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RW</para>
                /// </summary>
                [NameInMap("MountAccess")]
                [Validation(Required=false)]
                public string MountAccess { get; set; }

                /// <summary>
                /// <para>The mount path in the container.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/data</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The type of the mount option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FastReadWrite</para>
                /// </summary>
                [NameInMap("OptionType")]
                [Validation(Required=false)]
                public string OptionType { get; set; }

                /// <summary>
                /// <para>The mount type of the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;fs.oss.download.thread.concurrency&quot;: &quot;10&quot;,
                ///   &quot;fs.oss.upload.thread.concurrency&quot;: &quot;10&quot;,
                ///   &quot;fs.jindo.args&quot;: &quot;-oattr_timeout=3 -oentry_timeout=0 -onegative_timeout=0 -oauto_cache -ono_symlink&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// <para>The dataset URI.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://bucket-name.oss-cn-shanghai-internal.aliyuncs.com/data/path/</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

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
            /// <para>The dynamic mount configurations.</para>
            /// </summary>
            [NameInMap("DynamicMount")]
            [Validation(Required=false)]
            public DynamicMount DynamicMount { get; set; }

            /// <summary>
            /// <para>The ECS instance type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.c6.large</para>
            /// </summary>
            [NameInMap("EcsSpec")]
            [Validation(Required=false)]
            public string EcsSpec { get; set; }

            /// <summary>
            /// <para>The environment variables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{userName: &quot;Chris&quot;}</para>
            /// </summary>
            [NameInMap("EnvironmentVariables")]
            [Validation(Required=false)]
            public Dictionary<string, string> EnvironmentVariables { get; set; }

            /// <summary>
            /// <para>The time when the instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the instance was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The rule for stopping idle instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;InstanceId&quot;:&quot;dsw-05cefd0be2e5a278&quot;,&quot;CpuPercentThreshold&quot;:20,&quot;GpuPercentThreshold&quot;:10,&quot;MaxIdleTimeInMinutes&quot;:120,&quot;IdleTimeInMinutes&quot;:30}</para>
            /// </summary>
            [NameInMap("IdleInstanceCuller")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesIdleInstanceCuller IdleInstanceCuller { get; set; }
            public class ListInstancesResponseBodyInstancesIdleInstanceCuller : TeaModel {
                /// <summary>
                /// <para>The CPU utilization threshold. Unit: percentage. Valid values: 1 to 100. If the CPU utilization of the instance is lower than this threshold, the instance is considered idle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("CpuPercentThreshold")]
                [Validation(Required=false)]
                public int? CpuPercentThreshold { get; set; }

                /// <summary>
                /// <para>The GPU utilization threshold. Unit: percentage. Valid values: 1 to 100. This parameter takes effect only if the instance is of the GPU instance type. If both CPU and GPU utilization is lower than the thresholds, the instance is considered idle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("GpuPercentThreshold")]
                [Validation(Required=false)]
                public int? GpuPercentThreshold { get; set; }

                /// <summary>
                /// <para>The time duration for which the instance is idle. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("IdleTimeInMinutes")]
                [Validation(Required=false)]
                public int? IdleTimeInMinutes { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dsw-730xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The maximum time duration for which the instance is idle. Unit: minutes. If the time duration for which the instance is idle exceeds this value, the system automatically stops the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("MaxIdleTimeInMinutes")]
                [Validation(Required=false)]
                public int? MaxIdleTimeInMinutes { get; set; }

            }

            /// <summary>
            /// <para>The Base64-encoded account and password for the user\&quot;s private image. The password will be hidden.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aGFyYm9yYWlAeGltYWxheWE6KioqKioq</para>
            /// </summary>
            [NameInMap("ImageAuth")]
            [Validation(Required=false)]
            public string ImageAuth { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-05cefd0be2exxxx</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>py36_cpu_tf1.12_ubuntu</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The image address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry.cn-shanghai.aliyuncs.com/pai_product/tensorflow:py36_cpu_tf1.12_ubuntu</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsw-730xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>training_data</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The scheduled stop task.</para>
            /// </summary>
            [NameInMap("InstanceShutdownTimer")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesInstanceShutdownTimer InstanceShutdownTimer { get; set; }
            public class ListInstancesResponseBodyInstancesInstanceShutdownTimer : TeaModel {
                /// <summary>
                /// <para>The scheduled stop time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("DueTime")]
                [Validation(Required=false)]
                public string DueTime { get; set; }

                /// <summary>
                /// <para>The time when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>The time when the instance was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dsw-730xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The remaining time before the instance is stopped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600000</para>
                /// </summary>
                [NameInMap("RemainingTimeInMs")]
                [Validation(Required=false)]
                public long? RemainingTimeInMs { get; set; }

            }

            /// <summary>
            /// <para>The instance snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("InstanceSnapshotList")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesInstanceSnapshotList> InstanceSnapshotList { get; set; }
            public class ListInstancesResponseBodyInstancesInstanceSnapshotList : TeaModel {
                /// <summary>
                /// <para>The time when the snapshot was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>The time when the snapshot was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image-05cefd0be2exxxx</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The image name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>py36_cpu_tf1.12_ubuntu</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-shanghai.aliyuncs.com/pai_product/tensorflow:py36_cpu_tf1.12_ubuntu</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The error code of the instance snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internal Error</para>
                /// </summary>
                [NameInMap("ReasonCode")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

                /// <summary>
                /// <para>The error message of the instance snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ImagePullBackOff</para>
                /// </summary>
                [NameInMap("ReasonMessage")]
                [Validation(Required=false)]
                public string ReasonMessage { get; set; }

                /// <summary>
                /// <para>The URL of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://cr.console.aliyun.com/repository/cn-hangzhou/zouxu/kf/images">https://cr.console.aliyun.com/repository/cn-hangzhou/zouxu/kf/images</a></para>
                /// </summary>
                [NameInMap("RepositoryUrl")]
                [Validation(Required=false)]
                public string RepositoryUrl { get; set; }

                /// <summary>
                /// <para>The status of the instance snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pushing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The instance URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dsw-cn-shanghai.data.aliyun.com/notebook.htm?instance=39772#/">https://dsw-cn-shanghai.data.aliyun.com/notebook.htm?instance=39772#/</a></para>
            /// </summary>
            [NameInMap("InstanceUrl")]
            [Validation(Required=false)]
            public string InstanceUrl { get; set; }

            /// <summary>
            /// <para>The JupyterLab URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/lab/">https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/lab/</a></para>
            /// </summary>
            [NameInMap("JupyterlabUrl")]
            [Validation(Required=false)]
            public string JupyterlabUrl { get; set; }

            /// <summary>
            /// <para>The custom labels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;foo\&quot;: \&quot;bar\&quot;}</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesLabels> Labels { get; set; }
            public class ListInstancesResponseBodyInstancesLabels : TeaModel {
                /// <summary>
                /// <para>The custom label key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stsTokenOwner</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The custom label value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123xxxxxxxx</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The user image that was latest saved.</para>
            /// </summary>
            [NameInMap("LatestSnapshot")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesLatestSnapshot LatestSnapshot { get; set; }
            public class ListInstancesResponseBodyInstancesLatestSnapshot : TeaModel {
                /// <summary>
                /// <para>The time when the snapshot was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>The time when the snapshot was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtModifiedTime")]
                [Validation(Required=false)]
                public string GmtModifiedTime { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image-05cefd0be2exxxx</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The image name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>py36_cpu_tf1.12_ubuntu</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-shanghai.aliyuncs.com/pai_product/tensorflow:py36_cpu_tf1.12_ubuntu</para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The error code of the instance snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Internal Error</para>
                /// </summary>
                [NameInMap("ReasonCode")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

                /// <summary>
                /// <para>The error message of the instance snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ImagePullBackOff</para>
                /// </summary>
                [NameInMap("ReasonMessage")]
                [Validation(Required=false)]
                public string ReasonMessage { get; set; }

                /// <summary>
                /// <para>The URL of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://cr.console.aliyun.com/repository/cn-hangzhou/zouxu/kf/images">https://cr.console.aliyun.com/repository/cn-hangzhou/zouxu/kf/images</a></para>
                /// </summary>
                [NameInMap("RepositoryUrl")]
                [Validation(Required=false)]
                public string RepositoryUrl { get; set; }

                /// <summary>
                /// <para>The status of the instance snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pushing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("OversoldInfo")]
            [Validation(Required=false)]
            public string OversoldInfo { get; set; }

            [NameInMap("OversoldType")]
            [Validation(Required=false)]
            public string OversoldType { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayAsYouGo</description></item>
            /// <item><description>Subscription</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayAsYouGo</para>
            /// </summary>
            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The priority based on which resources are allocated to instances. Resources are preferentially allocated to instances with higher priorities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public long? Priority { get; set; }

            /// <summary>
            /// <para>The error code of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Internal Error</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The cause of the instance error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImagePullBackOff</para>
            /// </summary>
            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// <para>The resource configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;CPU&quot;:&quot;4&quot;,&quot;Memory&quot;:&quot;8Gi&quot;,&quot;SharedMemory&quot;:&quot;4Gi&quot;,&quot;GPU&quot;:&quot;1&quot;,&quot;GPUType&quot;:&quot;Tesla-V100-16G&quot;}</para>
            /// </summary>
            [NameInMap("RequestedResource")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesRequestedResource RequestedResource { get; set; }
            public class ListInstancesResponseBodyInstancesRequestedResource : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }

                /// <summary>
                /// <para>The number of GPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("GPU")]
                [Validation(Required=false)]
                public string GPU { get; set; }

                /// <summary>
                /// <para>The GPU memory type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v100</para>
                /// </summary>
                [NameInMap("GPUType")]
                [Validation(Required=false)]
                public string GPUType { get; set; }

                /// <summary>
                /// <para>The memory size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <para>The size of the shared memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("SharedMemory")]
                [Validation(Required=false)]
                public string SharedMemory { get; set; }

            }

            /// <summary>
            /// <para>The resource ID. This parameter is valid only if you set PaymentType to Subscription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dsw-123456789</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The specifications.</para>
            /// <list type="bullet">
            /// <item><description>In pay-as-you-go scenarios, the value is the specifications of the purchased ECS instance type.</description></item>
            /// <item><description>In subscription scenarios, the value is the requested number of CPU cores and memory size.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>resource_group</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("ServiceConfig")]
            [Validation(Required=false)]
            public ServiceConfig ServiceConfig { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class ListInstancesResponseBodyInstancesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The terminal URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/tty/">https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/tty/</a></para>
            /// </summary>
            [NameInMap("TerminalUrl")]
            [Validation(Required=false)]
            public string TerminalUrl { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1612285282502324</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试用户</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) configurations.</para>
            /// </summary>
            [NameInMap("UserVpc")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesUserVpc UserVpc { get; set; }
            public class ListInstancesResponseBodyInstancesUserVpc : TeaModel {
                [NameInMap("BandwidthLimit")]
                [Validation(Required=false)]
                public BandwidthLimit BandwidthLimit { get; set; }

                /// <summary>
                /// <para>The default route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eth0 | eth1</para>
                /// </summary>
                [NameInMap("DefaultRoute")]
                [Validation(Required=false)]
                public string DefaultRoute { get; set; }

                /// <summary>
                /// <para>The extended CIDR blocks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;192.168.0.1/24&quot;, &quot;192.168.1.1/24&quot;]</para>
                /// </summary>
                [NameInMap("ExtendedCIDRs")]
                [Validation(Required=false)]
                public List<string> ExtendedCIDRs { get; set; }

                /// <summary>
                /// <para>The forward information.</para>
                /// </summary>
                [NameInMap("ForwardInfos")]
                [Validation(Required=false)]
                public List<ForwardInfoResponse> ForwardInfos { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The security group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxxxxx</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxxxx</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxxxx</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The Web IDE URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/ide/">https://dsw-gateway-cn-shanghai.aliyun.com/dsw-39772/ide/</a></para>
            /// </summary>
            [NameInMap("WebIDEUrl")]
            [Validation(Required=false)]
            public string WebIDEUrl { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40823</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>training_data</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

            /// <summary>
            /// <para>The storage for the workspace. If you leave this parameter empty, the workspace uses File Storage NAS (NAS) storage, cloud disks, or local disks in sequence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-123456789</para>
            /// </summary>
            [NameInMap("WorkspaceSource")]
            [Validation(Required=false)]
            public string WorkspaceSource { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;XXX&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MigrationOptions")]
        [Validation(Required=false)]
        public Dictionary<string, object> MigrationOptions { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7D55162-4489-1619-AAF5-3F97D5FCA948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}

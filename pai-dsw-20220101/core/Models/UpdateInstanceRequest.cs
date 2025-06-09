// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the instance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: Accessible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE: Accessible only to you and the administrator of the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The affinity configuration.</para>
        /// </summary>
        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public UpdateInstanceRequestAffinity Affinity { get; set; }
        public class UpdateInstanceRequestAffinity : TeaModel {
            /// <summary>
            /// <para>The CPU affinity configuration. Only subscription instances that use general-purpose computing resources support CPU affinity configuration.</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public UpdateInstanceRequestAffinityCPU CPU { get; set; }
            public class UpdateInstanceRequestAffinityCPU : TeaModel {
                /// <summary>
                /// <para>Specifies whether CPU affinity is enabled.</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
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
        /// <para>The cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CloudDisks")]
        [Validation(Required=false)]
        public List<UpdateInstanceRequestCloudDisks> CloudDisks { get; set; }
        public class UpdateInstanceRequestCloudDisks : TeaModel {
            /// <summary>
            /// <para>If <b>Resource Type</b> is <b>Public Resource</b> or if <b>Resource Quota</b> is subscription-based general-purpose computing resources (CPU cores ≥ 2 and memory ≥ 4 GB, or configured with GPU):</para>
            /// <para>Each instance has a free system disk quota of 100 GiB for persistent storage. <b>If the DSW instance is stopped and not launched for more than 15 days, the disk is cleared</b>. The disk can be expanded. For specific pricing, refer to the console.</para>
            /// <para>**</para>
            /// <para><b>Warning</b></para>
            /// <list type="bullet">
            /// <item><description><para>After the expansion, you cannot reduce the storage space. Proceed with caution.</para>
            /// </description></item>
            /// <item><description><para>After the expansion, the disk is not cleared if the instance is stopped for more than 15 days. However, it will continue to incur fees.</para>
            /// </description></item>
            /// <item><description><para>If you delete the instance, the system disk is also released and the data stored in the disk is deleted. Make sure that you have backed up your data before you delete the instance.</para>
            /// </description></item>
            /// </list>
            /// <para>If you need persistent storage, you can <b>mount a dataset</b> or add the OSS, NAS, or CPFS path to the <b>storage path</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100Gi</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            /// <summary>
            /// <para>Disk type:</para>
            /// <list type="bullet">
            /// <item><description>rootfs: Mounts the disk as a system disk. The system environment is stored on the disk.</description></item>
            /// </list>
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
        public List<UpdateInstanceRequestDatasets> Datasets { get; set; }
        public class UpdateInstanceRequestDatasets : TeaModel {
            /// <summary>
            /// <para>The dataset ID. If the dataset is read-only, you cannot change the dataset pemission from read-only to read and write by using MountAccess.</para>
            /// <para>You can call <a href="https://help.aliyun.com/document_detail/457222.html">ListDatasets</a> to obtain the dataset ID. If you configure the dataset ID, you cannot configure the dataset URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-vsqjvsjp4orp5l206u</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The dataset version. You must also configure DatasetId. If you leave this parameter empty, the value v1 is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("DatasetVersion")]
            [Validation(Required=false)]
            public string DatasetVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether dynamic mounting is enabled. Default value: false.</para>
            /// <list type="bullet">
            /// <item><description>Currently, only instances using general-purpose computing resources are supported.</description></item>
            /// <item><description>Currently, only OSS datasets are supported. The mounted datasets are read-only.</description></item>
            /// <item><description>The MountPath of the dynamically mounted dataset must be a subpath of the root path. Example: /mnt/dynamic/data1/</description></item>
            /// <item><description>A dynamically mounted dataset must be after non-dynamic datasets.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Dynamic")]
            [Validation(Required=false)]
            public bool? Dynamic { get; set; }

            /// <summary>
            /// <para>The read and write permissions of the dataset. If the dataset is read-only, it cannot be changed to read and write.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RW</para>
            /// </summary>
            [NameInMap("MountAccess")]
            [Validation(Required=false)]
            public string MountAccess { get; set; }

            /// <summary>
            /// <para>The mount path of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mnt/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The mount type. You cannot specify Options at the same time. This is deprecated, you can use Options instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReadOnly</para>
            /// </summary>
            [NameInMap("OptionType")]
            [Validation(Required=false)]
            [Obsolete]
            public string OptionType { get; set; }

            /// <summary>
            /// <para>The custom dataset mount options. Only OSS is supported. You cannot specify OptionType at the same time. For more information, see <a href="https://www.alibabacloud.com/help/en/pai/user-guide/read-and-write-dataset-data">DSW mount configurations</a>.</para>
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
            /// <para>The URI of the storage service directory, which can be directly mounted. This parameter is mutually exclusive with DatasetId.</para>
            /// <para>URI formats of different types of storage:</para>
            /// <list type="bullet">
            /// <item><description>OSS: oss://bucket-name.oss-cn-shanghai-internal.aliyuncs.com/data/path/</description></item>
            /// <item><description>NAS: nas://29\<em>\<em>d-b12\</em>\</em>\*\*446.cn-hangzhou.nas.aliyuncs.com/data/path/</description></item>
            /// <item><description>Extreme NAS: nas://29\<em>\</em>\*\<em>123-y\</em>\*r.cn-hangzhou.extreme.nas.aliyuncs.com/data/path/</description></item>
            /// <item><description>CPFS: cpfs://cpfs-213\<em>\</em>\<em>\<em>87.cn-wulanchabu/ptc-292\</em>\</em>\<em>\</em>\<em>cbb/exp-290\</em>\<em>\</em>\<em>\</em>\<em>\</em>\*03e/data/path/</description></item>
            /// <item><description>Lingjun CPFS: bmcpfs://cpfs-290\<em>\</em>\<em>\</em>\<em>\<em>foflh-vpc-x\</em>\</em>\*\*8r.cn-wulanchabu.cpfs.aliyuncs.com/data/path/</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket-name.oss-cn-shanghai-internal.aliyuncs.com/data/path/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to delete the credential injection information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisassociateCredential")]
        [Validation(Required=false)]
        public bool? DisassociateCredential { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the associated datasets.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisassociateDatasets")]
        [Validation(Required=false)]
        public bool? DisassociateDatasets { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the NVIDIA driver configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisassociateDriver")]
        [Validation(Required=false)]
        public bool? DisassociateDriver { get; set; }

        [NameInMap("DisassociateEnvironmentVariables")]
        [Validation(Required=false)]
        public bool? DisassociateEnvironmentVariables { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the associated forward information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisassociateForwardInfos")]
        [Validation(Required=false)]
        public bool? DisassociateForwardInfos { get; set; }

        [NameInMap("DisassociateUserCommand")]
        [Validation(Required=false)]
        public bool? DisassociateUserCommand { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete the associated user VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisassociateVpc")]
        [Validation(Required=false)]
        public bool? DisassociateVpc { get; set; }

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
        /// <para>The dynamic mount configuration.</para>
        /// </summary>
        [NameInMap("DynamicMount")]
        [Validation(Required=false)]
        public DynamicMount DynamicMount { get; set; }

        /// <summary>
        /// <para>The ECS instance type of the instance. You can call <a href="https://help.aliyun.com/document_detail/470423.html">ListEcsSpecs</a> to obtain the ECS instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        [NameInMap("EnvironmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, object> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>The Base64-encoded account and password for the user‘s private image. The password will be hidden.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ImageAuth")]
        [Validation(Required=false)]
        public string ImageAuth { get; set; }

        /// <summary>
        /// <para>The image ID. You can call <a href="https://help.aliyun.com/document_detail/449118.html">ListImages</a> to obtain the image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-05cefd0be2exxxx</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image address. You can call <a href="https://help.aliyun.com/document_detail/449118.html">ListImages</a> to obtain the image address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/pai_product/tensorflow:py36_cpu_tf1.12_ubuntu</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The instance name. Format requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only letters, digits, and underscores (_).</description></item>
        /// <item><description>The name can be up to 27 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>training_data</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("OversoldType")]
        [Validation(Required=false)]
        public string OversoldType { get; set; }

        /// <summary>
        /// <para>The priority based on which resources are allocated to instances. Valid values: 1 to 9.</para>
        /// <list type="bullet">
        /// <item><description>1: the lowest priority.</description></item>
        /// <item><description>9 is the highest priority.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <para>The resource configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CPU&quot;:&quot;4&quot;,&quot;Memory&quot;:&quot;8Gi&quot;,&quot;SharedMemory&quot;:&quot;4Gi&quot;,&quot;GPU&quot;:&quot;1&quot;,&quot;GPUType&quot;:&quot;Tesla-V100-16G&quot;}</para>
        /// </summary>
        [NameInMap("RequestedResource")]
        [Validation(Required=false)]
        public UpdateInstanceRequestRequestedResource RequestedResource { get; set; }
        public class UpdateInstanceRequestRequestedResource : TeaModel {
            /// <summary>
            /// <para>The number of vCPU cores.</para>
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
            /// <para>The GPU type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v100</para>
            /// </summary>
            [NameInMap("GPUType")]
            [Validation(Required=false)]
            public string GPUType { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The shared memory size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("SharedMemory")]
            [Validation(Required=false)]
            public string SharedMemory { get; set; }

        }

        [NameInMap("UserCommand")]
        [Validation(Required=false)]
        public UpdateInstanceRequestUserCommand UserCommand { get; set; }
        public class UpdateInstanceRequestUserCommand : TeaModel {
            [NameInMap("OnStart")]
            [Validation(Required=false)]
            public UpdateInstanceRequestUserCommandOnStart OnStart { get; set; }
            public class UpdateInstanceRequestUserCommandOnStart : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }

        }

        /// <summary>
        /// <para>the User ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16122**********</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) configurations.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UpdateInstanceRequestUserVpc UserVpc { get; set; }
        public class UpdateInstanceRequestUserVpc : TeaModel {
            [NameInMap("BandwidthLimit")]
            [Validation(Required=false)]
            public BandwidthLimit BandwidthLimit { get; set; }

            /// <summary>
            /// <para>The default route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>eth0: The default network interface is used to access the Internet through the public gateway.</description></item>
            /// <item><description>eth1: The user\&quot;s Elastic Network Interface is used to access the Internet through the private gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>eth0</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            /// <summary>
            /// <para>The extended CIDR blocks.</para>
            /// <list type="bullet">
            /// <item><description>If you leave VSwitchId empty, this parameter is not required and the system automatically obtains all CIDR blocks in the VPC.</description></item>
            /// <item><description>If VSwitchId is not empty, this parameter is required. Specify all CIDR blocks in the VPC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;192.168.0.1/24&quot;, &quot;192.168.1.1/24&quot;]</para>
            /// </summary>
            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            /// <summary>
            /// <para>The forward configuration of the instance.</para>
            /// </summary>
            [NameInMap("ForwardInfos")]
            [Validation(Required=false)]
            public List<ForwardInfo> ForwardInfos { get; set; }

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
        /// <para>Specifies the storage corresponding to the working directory. You can mount disks or datasets to /mnt/workspace at the same time. OSS datasets and dynamically mounted datasets are not supported.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>rootfsCloudDisk: Mount disk to the working directory.</description></item>
        /// <item><description>Mount path of the dataset, such as /mnt/data: Datasets in URI format only support this method.</description></item>
        /// <item><description>Dataset ID, such as d-vsqjvs\<em>\</em>\*\*rp5l206u: If a single dataset is mounted to multiple paths, the first path is selected. We recommend that you do not use this method, use the mount path instead.</description></item>
        /// </list>
        /// <para>If you leave this parameter empty:</para>
        /// <list type="bullet">
        /// <item><description>If the instance uses cloud disks, cloud disks are selected by default.</description></item>
        /// <item><description>if no disks are available, the first NAS or CPFS dataset is selected as the working directory.</description></item>
        /// <item><description>If no disk, NAS, or CPFS datasets is available, the host space is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/data</para>
        /// </summary>
        [NameInMap("WorkspaceSource")]
        [Validation(Required=false)]
        public string WorkspaceSource { get; set; }

    }

}

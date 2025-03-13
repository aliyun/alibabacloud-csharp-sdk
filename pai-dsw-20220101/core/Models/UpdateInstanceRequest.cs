// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public UpdateInstanceRequestAffinity Affinity { get; set; }
        public class UpdateInstanceRequestAffinity : TeaModel {
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public UpdateInstanceRequestAffinityCPU CPU { get; set; }
            public class UpdateInstanceRequestAffinityCPU : TeaModel {
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
        public List<UpdateInstanceRequestCloudDisks> CloudDisks { get; set; }
        public class UpdateInstanceRequestCloudDisks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30Gi</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rootfs</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

        }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<UpdateInstanceRequestDatasets> Datasets { get; set; }
        public class UpdateInstanceRequestDatasets : TeaModel {
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

            /// <term><b>Obsolete</b></term>
            [NameInMap("OptionType")]
            [Validation(Required=false)]
            [Obsolete]
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

        [NameInMap("DisassociateCredential")]
        [Validation(Required=false)]
        public bool? DisassociateCredential { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisassociateDatasets")]
        [Validation(Required=false)]
        public bool? DisassociateDatasets { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisassociateDriver")]
        [Validation(Required=false)]
        public bool? DisassociateDriver { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisassociateForwardInfos")]
        [Validation(Required=false)]
        public bool? DisassociateForwardInfos { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisassociateVpc")]
        [Validation(Required=false)]
        public bool? DisassociateVpc { get; set; }

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
        /// <para>registry.cn-shanghai.aliyuncs.com/pai_product/tensorflow:py36_cpu_tf1.12_ubuntu</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>training_data</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;CPU&quot;:&quot;4&quot;,&quot;Memory&quot;:&quot;8Gi&quot;,&quot;SharedMemory&quot;:&quot;4Gi&quot;,&quot;GPU&quot;:&quot;1&quot;,&quot;GPUType&quot;:&quot;Tesla-V100-16G&quot;}</para>
        /// </summary>
        [NameInMap("RequestedResource")]
        [Validation(Required=false)]
        public UpdateInstanceRequestRequestedResource RequestedResource { get; set; }
        public class UpdateInstanceRequestRequestedResource : TeaModel {
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
        /// <para>1612285282502324</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UpdateInstanceRequestUserVpc UserVpc { get; set; }
        public class UpdateInstanceRequestUserVpc : TeaModel {
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
            public List<ForwardInfo> ForwardInfos { get; set; }

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
            /// <b>Example:</b>
            /// <para>vpc-xxxxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d-123456789</para>
        /// </summary>
        [NameInMap("WorkspaceSource")]
        [Validation(Required=false)]
        public string WorkspaceSource { get; set; }

    }

}

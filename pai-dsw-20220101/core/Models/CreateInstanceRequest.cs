// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public CreateInstanceRequestAffinity Affinity { get; set; }
        public class CreateInstanceRequestAffinity : TeaModel {
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public CreateInstanceRequestAffinityCPU CPU { get; set; }
            public class CreateInstanceRequestAffinityCPU : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

        }

        [NameInMap("CloudDisks")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestCloudDisks> CloudDisks { get; set; }
        public class CreateInstanceRequestCloudDisks : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public CreateInstanceRequestCloudDisksStatus Status { get; set; }
            public class CreateInstanceRequestCloudDisksStatus : TeaModel {
                [NameInMap("Available")]
                [Validation(Required=false)]
                public long? Available { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                [NameInMap("Usage")]
                [Validation(Required=false)]
                public long? Usage { get; set; }

            }

            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

        }

        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestDatasets> Datasets { get; set; }
        public class CreateInstanceRequestDatasets : TeaModel {
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

        [NameInMap("ImageAuth")]
        [Validation(Required=false)]
        public string ImageAuth { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestLabels> Labels { get; set; }
        public class CreateInstanceRequestLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("RequestedResource")]
        [Validation(Required=false)]
        public CreateInstanceRequestRequestedResource RequestedResource { get; set; }
        public class CreateInstanceRequestRequestedResource : TeaModel {
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

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateInstanceRequestUserVpc UserVpc { get; set; }
        public class CreateInstanceRequestUserVpc : TeaModel {
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            [NameInMap("ForwardInfos")]
            [Validation(Required=false)]
            public List<ForwardInfo> ForwardInfos { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("WorkspaceSource")]
        [Validation(Required=false)]
        public string WorkspaceSource { get; set; }

    }

}

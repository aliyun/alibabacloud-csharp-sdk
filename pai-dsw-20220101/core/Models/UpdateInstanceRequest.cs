// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class UpdateInstanceRequest : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("CloudDisks")]
        [Validation(Required=false)]
        public List<UpdateInstanceRequestCloudDisks> CloudDisks { get; set; }
        public class UpdateInstanceRequestCloudDisks : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

        }

        [NameInMap("Datasets")]
        [Validation(Required=false)]
        public List<UpdateInstanceRequestDatasets> Datasets { get; set; }
        public class UpdateInstanceRequestDatasets : TeaModel {
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

        [NameInMap("DisassociateDatasets")]
        [Validation(Required=false)]
        public bool? DisassociateDatasets { get; set; }

        [NameInMap("DisassociateDriver")]
        [Validation(Required=false)]
        public bool? DisassociateDriver { get; set; }

        [NameInMap("DisassociateForwardInfos")]
        [Validation(Required=false)]
        public bool? DisassociateForwardInfos { get; set; }

        [NameInMap("DisassociateVpc")]
        [Validation(Required=false)]
        public bool? DisassociateVpc { get; set; }

        [NameInMap("Driver")]
        [Validation(Required=false)]
        public string Driver { get; set; }

        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        [NameInMap("RequestedResource")]
        [Validation(Required=false)]
        public UpdateInstanceRequestRequestedResource RequestedResource { get; set; }
        public class UpdateInstanceRequestRequestedResource : TeaModel {
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

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UpdateInstanceRequestUserVpc UserVpc { get; set; }
        public class UpdateInstanceRequestUserVpc : TeaModel {
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

        [NameInMap("WorkspaceSource")]
        [Validation(Required=false)]
        public string WorkspaceSource { get; set; }

    }

}

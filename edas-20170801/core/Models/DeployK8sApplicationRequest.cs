// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeployK8sApplicationRequest : TeaModel {
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        [NameInMap("Args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("CpuLimit")]
        [Validation(Required=false)]
        public int? CpuLimit { get; set; }

        [NameInMap("MemoryLimit")]
        [Validation(Required=false)]
        public int? MemoryLimit { get; set; }

        [NameInMap("CpuRequest")]
        [Validation(Required=false)]
        public int? CpuRequest { get; set; }

        [NameInMap("MemoryRequest")]
        [Validation(Required=false)]
        public int? MemoryRequest { get; set; }

        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        [NameInMap("MountDescs")]
        [Validation(Required=false)]
        public string MountDescs { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("LocalVolume")]
        [Validation(Required=false)]
        public string LocalVolume { get; set; }

        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        [NameInMap("JDK")]
        [Validation(Required=false)]
        public string JDK { get; set; }

        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        [NameInMap("UriEncoding")]
        [Validation(Required=false)]
        public string UriEncoding { get; set; }

        [NameInMap("UseBodyEncoding")]
        [Validation(Required=false)]
        public bool? UseBodyEncoding { get; set; }

        [NameInMap("UpdateStrategy")]
        [Validation(Required=false)]
        public string UpdateStrategy { get; set; }

        [NameInMap("McpuRequest")]
        [Validation(Required=false)]
        public int? McpuRequest { get; set; }

        [NameInMap("McpuLimit")]
        [Validation(Required=false)]
        public int? McpuLimit { get; set; }

        [NameInMap("VolumesStr")]
        [Validation(Required=false)]
        public string VolumesStr { get; set; }

        [NameInMap("PackageVersionId")]
        [Validation(Required=false)]
        public string PackageVersionId { get; set; }

        [NameInMap("ChangeOrderDesc")]
        [Validation(Required=false)]
        public string ChangeOrderDesc { get; set; }

        [NameInMap("RuntimeClassName")]
        [Validation(Required=false)]
        public string RuntimeClassName { get; set; }

        [NameInMap("DeployAcrossZones")]
        [Validation(Required=false)]
        public string DeployAcrossZones { get; set; }

        [NameInMap("BatchTimeout")]
        [Validation(Required=false)]
        public int? BatchTimeout { get; set; }

        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public bool? EnableAhas { get; set; }

        [NameInMap("WebContainerConfig")]
        [Validation(Required=false)]
        public string WebContainerConfig { get; set; }

        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public string JavaStartUpConfig { get; set; }

        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        [NameInMap("DeployAcrossNodes")]
        [Validation(Required=false)]
        public string DeployAcrossNodes { get; set; }

        [NameInMap("TrafficControlStrategy")]
        [Validation(Required=false)]
        public string TrafficControlStrategy { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertK8sApplicationRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("ApplicationDescription")]
        [Validation(Required=false)]
        public string ApplicationDescription { get; set; }

        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public string BuildPackId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        [NameInMap("ConfigMountDescs")]
        [Validation(Required=false)]
        public string ConfigMountDescs { get; set; }

        [NameInMap("CsClusterId")]
        [Validation(Required=false)]
        public string CsClusterId { get; set; }

        [NameInMap("CustomAffinity")]
        [Validation(Required=false)]
        public string CustomAffinity { get; set; }

        [NameInMap("CustomTolerations")]
        [Validation(Required=false)]
        public string CustomTolerations { get; set; }

        [NameInMap("DeployAcrossNodes")]
        [Validation(Required=false)]
        public string DeployAcrossNodes { get; set; }

        [NameInMap("DeployAcrossZones")]
        [Validation(Required=false)]
        public string DeployAcrossZones { get; set; }

        [NameInMap("EdasContainerVersion")]
        [Validation(Required=false)]
        public string EdasContainerVersion { get; set; }

        [NameInMap("EmptyDirs")]
        [Validation(Required=false)]
        public string EmptyDirs { get; set; }

        [NameInMap("EnableAhas")]
        [Validation(Required=false)]
        public bool? EnableAhas { get; set; }

        [NameInMap("EnableAsm")]
        [Validation(Required=false)]
        public bool? EnableAsm { get; set; }

        [NameInMap("EnvFroms")]
        [Validation(Required=false)]
        public string EnvFroms { get; set; }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("InternetSlbId")]
        [Validation(Required=false)]
        public string InternetSlbId { get; set; }

        [NameInMap("InternetSlbPort")]
        [Validation(Required=false)]
        public int? InternetSlbPort { get; set; }

        [NameInMap("InternetSlbProtocol")]
        [Validation(Required=false)]
        public string InternetSlbProtocol { get; set; }

        [NameInMap("InternetTargetPort")]
        [Validation(Required=false)]
        public int? InternetTargetPort { get; set; }

        [NameInMap("IntranetSlbId")]
        [Validation(Required=false)]
        public string IntranetSlbId { get; set; }

        [NameInMap("IntranetSlbPort")]
        [Validation(Required=false)]
        public int? IntranetSlbPort { get; set; }

        [NameInMap("IntranetSlbProtocol")]
        [Validation(Required=false)]
        public string IntranetSlbProtocol { get; set; }

        [NameInMap("IntranetTargetPort")]
        [Validation(Required=false)]
        public int? IntranetTargetPort { get; set; }

        [NameInMap("IsMultilingualApp")]
        [Validation(Required=false)]
        public bool? IsMultilingualApp { get; set; }

        [NameInMap("JDK")]
        [Validation(Required=false)]
        public string JDK { get; set; }

        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public string JavaStartUpConfig { get; set; }

        [NameInMap("LimitCpu")]
        [Validation(Required=false)]
        public int? LimitCpu { get; set; }

        [NameInMap("LimitMem")]
        [Validation(Required=false)]
        public int? LimitMem { get; set; }

        [NameInMap("LimitmCpu")]
        [Validation(Required=false)]
        public int? LimitmCpu { get; set; }

        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        [NameInMap("LocalVolume")]
        [Validation(Required=false)]
        public string LocalVolume { get; set; }

        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        [NameInMap("MountDescs")]
        [Validation(Required=false)]
        public string MountDescs { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NasId")]
        [Validation(Required=false)]
        public string NasId { get; set; }

        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        [NameInMap("PackageUrl")]
        [Validation(Required=false)]
        public string PackageUrl { get; set; }

        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        [NameInMap("PvcMountDescs")]
        [Validation(Required=false)]
        public string PvcMountDescs { get; set; }

        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        [NameInMap("RequestsCpu")]
        [Validation(Required=false)]
        public int? RequestsCpu { get; set; }

        [NameInMap("RequestsMem")]
        [Validation(Required=false)]
        public int? RequestsMem { get; set; }

        [NameInMap("RequestsmCpu")]
        [Validation(Required=false)]
        public int? RequestsmCpu { get; set; }

        [NameInMap("RuntimeClassName")]
        [Validation(Required=false)]
        public string RuntimeClassName { get; set; }

        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("UriEncoding")]
        [Validation(Required=false)]
        public string UriEncoding { get; set; }

        [NameInMap("UseBodyEncoding")]
        [Validation(Required=false)]
        public bool? UseBodyEncoding { get; set; }

        [NameInMap("WebContainer")]
        [Validation(Required=false)]
        public string WebContainer { get; set; }

        [NameInMap("WebContainerConfig")]
        [Validation(Required=false)]
        public string WebContainerConfig { get; set; }

    }

}

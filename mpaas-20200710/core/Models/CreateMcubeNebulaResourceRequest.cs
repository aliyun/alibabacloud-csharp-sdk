// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class CreateMcubeNebulaResourceRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public int? AutoInstall { get; set; }

        [NameInMap("ClientVersionMax")]
        [Validation(Required=false)]
        public string ClientVersionMax { get; set; }

        [NameInMap("ClientVersionMin")]
        [Validation(Required=false)]
        public string ClientVersionMin { get; set; }

        [NameInMap("CustomDomainName")]
        [Validation(Required=false)]
        public string CustomDomainName { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("H5Id")]
        [Validation(Required=false)]
        public string H5Id { get; set; }

        [NameInMap("H5Name")]
        [Validation(Required=false)]
        public string H5Name { get; set; }

        [NameInMap("H5Version")]
        [Validation(Required=false)]
        public string H5Version { get; set; }

        [NameInMap("InstallType")]
        [Validation(Required=false)]
        public int? InstallType { get; set; }

        [NameInMap("MainUrl")]
        [Validation(Required=false)]
        public string MainUrl { get; set; }

        [NameInMap("OnexFlag")]
        [Validation(Required=false)]
        public bool? OnexFlag { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("RepeatNebula")]
        [Validation(Required=false)]
        public int? RepeatNebula { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        [NameInMap("SubUrl")]
        [Validation(Required=false)]
        public string SubUrl { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("Vhost")]
        [Validation(Required=false)]
        public string Vhost { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

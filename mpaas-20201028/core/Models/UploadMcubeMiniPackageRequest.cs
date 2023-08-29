// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class UploadMcubeMiniPackageRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public long? AutoInstall { get; set; }

        [NameInMap("ClientVersionMax")]
        [Validation(Required=false)]
        public string ClientVersionMax { get; set; }

        [NameInMap("ClientVersionMin")]
        [Validation(Required=false)]
        public string ClientVersionMin { get; set; }

        [NameInMap("EnableKeepAlive")]
        [Validation(Required=false)]
        public string EnableKeepAlive { get; set; }

        [NameInMap("EnableOptionMenu")]
        [Validation(Required=false)]
        public string EnableOptionMenu { get; set; }

        [NameInMap("EnableTabBar")]
        [Validation(Required=false)]
        public long? EnableTabBar { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        [NameInMap("H5Id")]
        [Validation(Required=false)]
        public string H5Id { get; set; }

        [NameInMap("H5Name")]
        [Validation(Required=false)]
        public string H5Name { get; set; }

        [NameInMap("H5Version")]
        [Validation(Required=false)]
        public string H5Version { get; set; }

        [NameInMap("IconFileUrl")]
        [Validation(Required=false)]
        public string IconFileUrl { get; set; }

        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        [NameInMap("InstallType")]
        [Validation(Required=false)]
        public long? InstallType { get; set; }

        [NameInMap("MainUrl")]
        [Validation(Required=false)]
        public string MainUrl { get; set; }

        [NameInMap("OnexFlag")]
        [Validation(Required=false)]
        public bool? OnexFlag { get; set; }

        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public long? PackageType { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("ResourceFileUrl")]
        [Validation(Required=false)]
        public string ResourceFileUrl { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        [NameInMap("Vhost")]
        [Validation(Required=false)]
        public string Vhost { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class UploadMcubeMiniPackageRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AutoInstall")]
        [Validation(Required=false)]
        public long? AutoInstall { get; set; }

        [NameInMap("ClientVersionMax")]
        [Validation(Required=false)]
        public string ClientVersionMax { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientVersionMin")]
        [Validation(Required=false)]
        public string ClientVersionMin { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnableKeepAlive")]
        [Validation(Required=false)]
        public string EnableKeepAlive { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnableOptionMenu")]
        [Validation(Required=false)]
        public string EnableOptionMenu { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnableTabBar")]
        [Validation(Required=false)]
        public long? EnableTabBar { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("H5Id")]
        [Validation(Required=false)]
        public string H5Id { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("H5Name")]
        [Validation(Required=false)]
        public string H5Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("H5Version")]
        [Validation(Required=false)]
        public string H5Version { get; set; }

        [NameInMap("IconFileUrl")]
        [Validation(Required=false)]
        public string IconFileUrl { get; set; }

        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstallType")]
        [Validation(Required=false)]
        public long? InstallType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MainUrl")]
        [Validation(Required=false)]
        public string MainUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OnexFlag")]
        [Validation(Required=false)]
        public bool? OnexFlag { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public long? PackageType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceFileUrl")]
        [Validation(Required=false)]
        public string ResourceFileUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Vhost")]
        [Validation(Required=false)]
        public string Vhost { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateMdsCubeResourceRequest : TeaModel {
        [NameInMap("AndroidMaxVersion")]
        [Validation(Required=false)]
        public string AndroidMaxVersion { get; set; }

        [NameInMap("AndroidMinVersion")]
        [Validation(Required=false)]
        public string AndroidMinVersion { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("IosMaxVersion")]
        [Validation(Required=false)]
        public string IosMaxVersion { get; set; }

        [NameInMap("IosMinVersion")]
        [Validation(Required=false)]
        public string IosMinVersion { get; set; }

        [NameInMap("MockDataUrl")]
        [Validation(Required=false)]
        public string MockDataUrl { get; set; }

        [NameInMap("OnexFlag")]
        [Validation(Required=false)]
        public bool? OnexFlag { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("PreviewPictureUrl")]
        [Validation(Required=false)]
        public string PreviewPictureUrl { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("TemplateResourceDesc")]
        [Validation(Required=false)]
        public string TemplateResourceDesc { get; set; }

        [NameInMap("TemplateResourceVersion")]
        [Validation(Required=false)]
        public string TemplateResourceVersion { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

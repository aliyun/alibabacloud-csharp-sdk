// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class UpdateMcubeWhitelistRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("KeyIds")]
        [Validation(Required=false)]
        public string KeyIds { get; set; }

        [NameInMap("OnexFlag")]
        [Validation(Required=false)]
        public bool? OnexFlag { get; set; }

        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

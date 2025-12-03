// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetShareRelationship : TeaModel {
        [NameInMap("AllowedMountAccessLevels")]
        [Validation(Required=false)]
        public List<string> AllowedMountAccessLevels { get; set; }

        [NameInMap("ExpiresAt")]
        [Validation(Required=false)]
        public string ExpiresAt { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("IsSecureMode")]
        [Validation(Required=false)]
        public bool? IsSecureMode { get; set; }

        [NameInMap("SharedAt")]
        [Validation(Required=false)]
        public string SharedAt { get; set; }

        [NameInMap("SourceTenantId")]
        [Validation(Required=false)]
        public string SourceTenantId { get; set; }

        [NameInMap("SourceWorkspaceId")]
        [Validation(Required=false)]
        public string SourceWorkspaceId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

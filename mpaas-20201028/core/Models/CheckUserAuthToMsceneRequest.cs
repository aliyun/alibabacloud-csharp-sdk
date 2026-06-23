// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CheckUserAuthToMsceneRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AuthToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        [NameInMap("MiniProgramId")]
        [Validation(Required=false)]
        public string MiniProgramId { get; set; }

        [NameInMap("OpenUid")]
        [Validation(Required=false)]
        public string OpenUid { get; set; }

        [NameInMap("PlatformId")]
        [Validation(Required=false)]
        public string PlatformId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

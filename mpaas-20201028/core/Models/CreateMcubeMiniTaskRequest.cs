// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateMcubeMiniTaskRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("GreyConfigInfo")]
        [Validation(Required=false)]
        public string GreyConfigInfo { get; set; }

        [NameInMap("GreyEndtimeData")]
        [Validation(Required=false)]
        public string GreyEndtimeData { get; set; }

        [NameInMap("GreyNum")]
        [Validation(Required=false)]
        public long? GreyNum { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("PackageId")]
        [Validation(Required=false)]
        public long? PackageId { get; set; }

        [NameInMap("PublishMode")]
        [Validation(Required=false)]
        public long? PublishMode { get; set; }

        [NameInMap("PublishType")]
        [Validation(Required=false)]
        public long? PublishType { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("WhitelistIds")]
        [Validation(Required=false)]
        public string WhitelistIds { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

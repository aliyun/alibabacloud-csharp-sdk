// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreatePayOrderToMsenceRequest : TeaModel {
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AuthToken")]
        [Validation(Required=false)]
        public string AuthToken { get; set; }

        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfo { get; set; }

        [NameInMap("MiniProgramId")]
        [Validation(Required=false)]
        public string MiniProgramId { get; set; }

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

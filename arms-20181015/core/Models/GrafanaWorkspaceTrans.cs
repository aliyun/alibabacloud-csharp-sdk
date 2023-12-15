// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20181015.Models
{
    public class GrafanaWorkspaceTrans : TeaModel {
        [NameInMap("apiUrl")]
        [Validation(Required=false)]
        public string ApiUrl { get; set; }

        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public float? GmtCreate { get; set; }

        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public float? GmtModified { get; set; }

        [NameInMap("grafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("processStatus")]
        [Validation(Required=false)]
        public string ProcessStatus { get; set; }

        [NameInMap("transDetails")]
        [Validation(Required=false)]
        public List<GrafanaWorkspaceTransDetail> TransDetails { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

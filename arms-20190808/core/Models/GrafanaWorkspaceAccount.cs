// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceAccount : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        [NameInMap("accountNotes")]
        [Validation(Required=false)]
        public string AccountNotes { get; set; }

        [NameInMap("aliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

        [NameInMap("aliyunUserName")]
        [Validation(Required=false)]
        public string AliyunUserName { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public float? GmtCreate { get; set; }

        [NameInMap("orgs")]
        [Validation(Required=false)]
        public List<GrafanaWorkspaceUserOrg> Orgs { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}

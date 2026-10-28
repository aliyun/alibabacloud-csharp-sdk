// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DownloadJobResult : TeaModel {
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("DownloadJobId")]
        [Validation(Required=false)]
        public string DownloadJobId { get; set; }

        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("LogCount")]
        [Validation(Required=false)]
        public int? LogCount { get; set; }

        [NameInMap("PodIds")]
        [Validation(Required=false)]
        public List<string> PodIds { get; set; }

        [NameInMap("PodUids")]
        [Validation(Required=false)]
        public List<string> PodUids { get; set; }

        [NameInMap("SourceJobId")]
        [Validation(Required=false)]
        public string SourceJobId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UrlExpireTime")]
        [Validation(Required=false)]
        public string UrlExpireTime { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}

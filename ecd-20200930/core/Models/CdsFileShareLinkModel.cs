// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CdsFileShareLinkModel : TeaModel {
        [NameInMap("AccessCount")]
        [Validation(Required=false)]
        public long? AccessCount { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisableDownload")]
        [Validation(Required=false)]
        public bool? DisableDownload { get; set; }

        [NameInMap("DisablePreview")]
        [Validation(Required=false)]
        public bool? DisablePreview { get; set; }

        [NameInMap("DisableSave")]
        [Validation(Required=false)]
        public bool? DisableSave { get; set; }

        [NameInMap("DownloadCount")]
        [Validation(Required=false)]
        public long? DownloadCount { get; set; }

        [NameInMap("DownloadLimit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        [NameInMap("DriveId")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIds { get; set; }

        [NameInMap("ModifiyTime")]
        [Validation(Required=false)]
        public string ModifiyTime { get; set; }

        [NameInMap("PreviewCount")]
        [Validation(Required=false)]
        public long? PreviewCount { get; set; }

        [NameInMap("PreviewLimit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        [NameInMap("ReportCount")]
        [Validation(Required=false)]
        public long? ReportCount { get; set; }

        [NameInMap("SaveCount")]
        [Validation(Required=false)]
        public long? SaveCount { get; set; }

        [NameInMap("SaveLimit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        [NameInMap("ShareId")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        [NameInMap("ShareLink")]
        [Validation(Required=false)]
        public string ShareLink { get; set; }

        [NameInMap("ShareName")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        [NameInMap("SharePwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("VideoPreviewCount")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}

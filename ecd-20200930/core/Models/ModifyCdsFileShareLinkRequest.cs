// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCdsFileShareLinkRequest : TeaModel {
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

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

        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

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

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateShareLinkRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("disable_download")]
        [Validation(Required=false)]
        public bool? DisableDownload { get; set; }

        [NameInMap("disable_preview")]
        [Validation(Required=false)]
        public bool? DisablePreview { get; set; }

        [NameInMap("disable_save")]
        [Validation(Required=false)]
        public bool? DisableSave { get; set; }

        [NameInMap("download_count")]
        [Validation(Required=false)]
        public long? DownloadCount { get; set; }

        [NameInMap("download_limit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("preview_count")]
        [Validation(Required=false)]
        public long? PreviewCount { get; set; }

        [NameInMap("preview_limit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        [NameInMap("report_count")]
        [Validation(Required=false)]
        public long? ReportCount { get; set; }

        [NameInMap("save_count")]
        [Validation(Required=false)]
        public long? SaveCount { get; set; }

        [NameInMap("save_limit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        [NameInMap("share_name")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        [NameInMap("share_pwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("video_preview_count")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}

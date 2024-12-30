// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ShareLink : TeaModel {
        [NameInMap("access_count")]
        [Validation(Required=false)]
        public long? AccessCount { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

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

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        [NameInMap("file_id_list")]
        [Validation(Required=false)]
        public List<string> FileIdList { get; set; }

        [NameInMap("office_editable")]
        [Validation(Required=false)]
        public bool? OfficeEditable { get; set; }

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

        [NameInMap("save_download_limit")]
        [Validation(Required=false)]
        public long? SaveDownloadLimit { get; set; }

        [NameInMap("save_limit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        [NameInMap("share_all_files")]
        [Validation(Required=false)]
        public bool? ShareAllFiles { get; set; }

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

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("video_preview_count")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}

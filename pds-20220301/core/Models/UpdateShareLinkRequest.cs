// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateShareLinkRequest : TeaModel {
        /// <summary>
        /// The description of the share link. The description can be up to 1,024 characters in length.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to prohibit the downloads of the shared files.
        /// </summary>
        [NameInMap("disable_download")]
        [Validation(Required=false)]
        public bool? DisableDownload { get; set; }

        /// <summary>
        /// Specifies whether to prohibit the previews of the shared files.
        /// </summary>
        [NameInMap("disable_preview")]
        [Validation(Required=false)]
        public bool? DisablePreview { get; set; }

        /// <summary>
        /// Specifies whether to prohibit the saves of the shared files.
        /// </summary>
        [NameInMap("disable_save")]
        [Validation(Required=false)]
        public bool? DisableSave { get; set; }

        /// <summary>
        /// The number of times that the shared files are downloaded. The value must be greater than or equal to 0.
        /// </summary>
        [NameInMap("download_count")]
        [Validation(Required=false)]
        public long? DownloadCount { get; set; }

        /// <summary>
        /// The maximum number of times that the shared files can be downloaded. The value must be greater than or equal to 0. A value of 0 specifies that the number is unlimited.
        /// </summary>
        [NameInMap("download_limit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        /// <summary>
        /// The time when the share link expires. The time follows the RFC 3339 standard. Example: 2020-06-28T11:33:00.000+08:00. If you leave this parameter empty, the share link never expires.
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// The number of times that the shared files are previewed. The value must be greater than or equal to 0.
        /// </summary>
        [NameInMap("preview_count")]
        [Validation(Required=false)]
        public long? PreviewCount { get; set; }

        /// <summary>
        /// The maximum number of times that the shared files can be previewed. The value must be greater than or equal to 0. A value of 0 specifies that the number is unlimited.
        /// </summary>
        [NameInMap("preview_limit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        /// <summary>
        /// The number of times that the shared files are reported. The value must be greater than or equal to 0.
        /// </summary>
        [NameInMap("report_count")]
        [Validation(Required=false)]
        public long? ReportCount { get; set; }

        /// <summary>
        /// The number of times that the shared files are saved. The value must be greater than or equal to 0.
        /// </summary>
        [NameInMap("save_count")]
        [Validation(Required=false)]
        public long? SaveCount { get; set; }

        /// <summary>
        /// The maximum number of times that the shared files can be saved. The value must be greater than or equal to 0. A value of 0 specifies that the number is unlimited.
        /// </summary>
        [NameInMap("save_limit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        /// <summary>
        /// The share ID.
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// The name of the share link. By default, the name of the first file is used. The name can be up to 128 characters in length.
        /// </summary>
        [NameInMap("share_name")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// The access code. The access code can be up to 64 characters in length. A value of 0 specifies an empty string.
        /// </summary>
        [NameInMap("share_pwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

        /// <summary>
        /// The state of the share link. Valid values:
        /// 
        /// *   disabled: The share link is canceled.
        /// *   enabled: The share link is effective.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The number of times that the videos are previewed in the shared files. The value must be greater than or equal to 0.
        /// </summary>
        [NameInMap("video_preview_count")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}

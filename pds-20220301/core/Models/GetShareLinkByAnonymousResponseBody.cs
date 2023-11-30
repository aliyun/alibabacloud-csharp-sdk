// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetShareLinkByAnonymousResponseBody : TeaModel {
        /// <summary>
        /// The number of times that the shared files are visited.
        /// </summary>
        [NameInMap("access_count")]
        [Validation(Required=false)]
        public long? AccessCount { get; set; }

        /// <summary>
        /// The profile picture of the user who created the share link.
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// The ID of the user who created the share link.
        /// </summary>
        [NameInMap("creator_id")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// The name of the user who created the share link. The value is masked.
        /// </summary>
        [NameInMap("creator_name")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// The mobile number of the user who created the share link. The value is masked.
        /// </summary>
        [NameInMap("creator_phone")]
        [Validation(Required=false)]
        public string CreatorPhone { get; set; }

        /// <summary>
        /// Indicates whether the downloads of the shared files are prohibited.
        /// </summary>
        [NameInMap("disable_download")]
        [Validation(Required=false)]
        public bool? DisableDownload { get; set; }

        /// <summary>
        /// Indicates whether the previews of the shared files are prohibited.
        /// </summary>
        [NameInMap("disable_preview")]
        [Validation(Required=false)]
        public bool? DisablePreview { get; set; }

        /// <summary>
        /// Indicates whether the saves of the shared files are prohibited.
        /// </summary>
        [NameInMap("disable_save")]
        [Validation(Required=false)]
        public bool? DisableSave { get; set; }

        /// <summary>
        /// The number of times that the shared files are downloaded.
        /// </summary>
        [NameInMap("download_count")]
        [Validation(Required=false)]
        public long? DownloadCount { get; set; }

        /// <summary>
        /// The maximum number of times that the shared files can be downloaded.
        /// </summary>
        [NameInMap("download_limit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        /// <summary>
        /// The time when the share link expires.
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// The number of times that the shared files are previewed.
        /// </summary>
        [NameInMap("preview_count")]
        [Validation(Required=false)]
        public long? PreviewCount { get; set; }

        /// <summary>
        /// The maximum number of times that the shared files can be previewed.
        /// </summary>
        [NameInMap("preview_limit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        /// <summary>
        /// The number of times that the shared files are reported.
        /// </summary>
        [NameInMap("report_count")]
        [Validation(Required=false)]
        public long? ReportCount { get; set; }

        /// <summary>
        /// The number of times that the shared files are saved.
        /// </summary>
        [NameInMap("save_count")]
        [Validation(Required=false)]
        public long? SaveCount { get; set; }

        /// <summary>
        /// The maximum number of times that the shared files can be saved and downloaded.
        /// </summary>
        [NameInMap("save_download_limit")]
        [Validation(Required=false)]
        public long? SaveDownloadLimit { get; set; }

        /// <summary>
        /// The maximum number of times that the shared files can be saved.
        /// </summary>
        [NameInMap("save_limit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        /// <summary>
        /// The name of the share link.
        /// </summary>
        [NameInMap("share_name")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// The time when the share link was last modified.
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// The number of times that the videos are previewed in the shared files.
        /// </summary>
        [NameInMap("video_preview_count")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}

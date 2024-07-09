// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCdsFileShareLinkRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud disk.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// The description of the file sharing task. The description must be 0 to 1,024 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to prohibit the download of the files that are being shared.
        /// 
        /// Valid values:
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("DisableDownload")]
        [Validation(Required=false)]
        public bool? DisableDownload { get; set; }

        /// <summary>
        /// Specifies whether to prohibit the preview of the files that are being shared.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("DisablePreview")]
        [Validation(Required=false)]
        public bool? DisablePreview { get; set; }

        /// <summary>
        /// Specifies whether to prohibit the dump of the files that are being shared.
        /// 
        /// Valid values:
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("DisableSave")]
        [Validation(Required=false)]
        public bool? DisableSave { get; set; }

        /// <summary>
        /// The number of times that the shared files are downloaded. The value of this parameter must be equal to or greater than 0.
        /// </summary>
        [NameInMap("DownloadCount")]
        [Validation(Required=false)]
        public long? DownloadCount { get; set; }

        /// <summary>
        /// The limit on the number of times that the shared files can be downloaded. The value of this parameter must be equal to or greater than 0. The value 0 specifies that no limit is imposed on the number of times that the shared files can be downloaded.
        /// </summary>
        [NameInMap("DownloadLimit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        /// <summary>
        /// The time when the file sharing link expires. The value of this parameter follows the RFC 3339 standard. Example: "2020-06-28T11:33:00.000+08:00". If this parameter is set to "", the file sharing link never expires.
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// The number of times that the shared files are previewed. The value of this parameter must be equal to or greater than 0.
        /// </summary>
        [NameInMap("PreviewCount")]
        [Validation(Required=false)]
        public long? PreviewCount { get; set; }

        /// <summary>
        /// The limit on the number of times that the shared files can be previewed. The value of this parameter must be equal to or greater than 0. The value 0 specifies that no limit is imposed on the number of times that the shared files can be downloaded.
        /// </summary>
        [NameInMap("PreviewLimit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        /// <summary>
        /// The number of times that the shared files are reported. The value of this parameter must be equal to or greater than 0.
        /// </summary>
        [NameInMap("ReportCount")]
        [Validation(Required=false)]
        public long? ReportCount { get; set; }

        /// <summary>
        /// The number of times that the shared files are dumped. The value of this parameter must be equal to or greater than 0.
        /// </summary>
        [NameInMap("SaveCount")]
        [Validation(Required=false)]
        public long? SaveCount { get; set; }

        /// <summary>
        /// The limit on the number of times that the shared files can be dumped. The value of this parameter must be equal to or greater than 0. The value 0 specifies that no limit is imposed on the number of times that the shared files can be downloaded.
        /// </summary>
        [NameInMap("SaveLimit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        /// <summary>
        /// The ID of the file sharing task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ShareId")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// The name of the file sharing task. If you do not configure this parameter, the sharing task name is the first ID that is returned in the file_id_list value.
        /// 
        /// >  The sharing task name must be 0 to 128 characters in length.
        /// </summary>
        [NameInMap("ShareName")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// The length of the access code. Valid values: 6 to 8. Unit: bytes. If you leave this parameter empty or set it to null, no access code is required. If you use a token to share files, you do not need to configure this parameter. The access code can contain only visible ASCII characters.
        /// </summary>
        [NameInMap("SharePwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

        /// <summary>
        /// The sharing status.
        /// 
        /// Valid values:
        /// 
        /// *   disabled: The sharing task is canceled.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   enabled: The sharing task is valid.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The number of times that the videos are previewed in the shared files. The value of this parameter must be equal to or greater than 0.
        /// </summary>
        [NameInMap("VideoPreviewCount")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}

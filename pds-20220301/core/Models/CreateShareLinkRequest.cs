// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateShareLinkRequest : TeaModel {
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

        [NameInMap("download_limit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("file_id_list")]
        [Validation(Required=false)]
        public string FileIdList { get; set; }

        [NameInMap("preview_limit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        [NameInMap("save_limit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        [NameInMap("share_name")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        [NameInMap("share_pwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}

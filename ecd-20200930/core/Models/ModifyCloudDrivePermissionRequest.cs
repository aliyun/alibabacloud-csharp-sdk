// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCloudDrivePermissionRequest : TeaModel {
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        [NameInMap("DownloadEndUserIds")]
        [Validation(Required=false)]
        public List<string> DownloadEndUserIds { get; set; }

        [NameInMap("DownloadUploadEndUserIds")]
        [Validation(Required=false)]
        public List<string> DownloadUploadEndUserIds { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}

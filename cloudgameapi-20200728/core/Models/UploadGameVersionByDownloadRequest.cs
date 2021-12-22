// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class UploadGameVersionByDownloadRequest : TeaModel {
        [NameInMap("DownloadType")]
        [Validation(Required=false)]
        public string DownloadType { get; set; }

        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        [NameInMap("GameVersion")]
        [Validation(Required=false)]
        public string GameVersion { get; set; }

        [NameInMap("Hash")]
        [Validation(Required=false)]
        public string Hash { get; set; }

        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}

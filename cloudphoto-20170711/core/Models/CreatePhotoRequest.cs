// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class CreatePhotoRequest : TeaModel {
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("UploadType")]
        [Validation(Required=false)]
        public string UploadType { get; set; }

        [NameInMap("PhotoTitle")]
        [Validation(Required=false)]
        public string PhotoTitle { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("LibraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        [NameInMap("Staging")]
        [Validation(Required=false)]
        public string Staging { get; set; }

        [NameInMap("ShareExpireTime")]
        [Validation(Required=false)]
        public long? ShareExpireTime { get; set; }

        [NameInMap("TakenAt")]
        [Validation(Required=false)]
        public long? TakenAt { get; set; }

    }

}

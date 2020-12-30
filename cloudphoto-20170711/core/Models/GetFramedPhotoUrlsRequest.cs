// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class GetFramedPhotoUrlsRequest : TeaModel {
        [NameInMap("FrameId")]
        [Validation(Required=false)]
        public string FrameId { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("LibraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        [NameInMap("PhotoId")]
        [Validation(Required=false)]
        public List<int?> PhotoId { get; set; }

    }

}

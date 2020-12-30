// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class MoveFacePhotosRequest : TeaModel {
        [NameInMap("SourceFaceId")]
        [Validation(Required=false)]
        public long? SourceFaceId { get; set; }

        [NameInMap("TargetFaceId")]
        [Validation(Required=false)]
        public long? TargetFaceId { get; set; }

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

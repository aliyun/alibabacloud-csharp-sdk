// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class SetFaceCoverRequest : TeaModel {
        [NameInMap("FaceId")]
        [Validation(Required=false)]
        public long? FaceId { get; set; }

        [NameInMap("PhotoId")]
        [Validation(Required=false)]
        public long? PhotoId { get; set; }

        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("LibraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

    }

}

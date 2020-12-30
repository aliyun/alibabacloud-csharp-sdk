// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Multimediaai20190810.Models
{
    public class ListFaceImagesRequest : TeaModel {
        [NameInMap("FaceGroupId")]
        [Validation(Required=false)]
        public long? FaceGroupId { get; set; }

        [NameInMap("FacePersonId")]
        [Validation(Required=false)]
        public long? FacePersonId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Multimediaai20190810.Models
{
    public class ListFacePersonsRequest : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("FaceGroupId")]
        [Validation(Required=false)]
        public long? FaceGroupId { get; set; }

        [NameInMap("FacePersonName")]
        [Validation(Required=false)]
        public string FacePersonName { get; set; }

    }

}

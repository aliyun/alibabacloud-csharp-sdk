// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApiOperationsRequest : TeaModel {
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("pathLike")]
        [Validation(Required=false)]
        public string PathLike { get; set; }

    }

}

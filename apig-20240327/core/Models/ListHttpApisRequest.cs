// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApisRequest : TeaModel {
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("publishedOnly")]
        [Validation(Required=false)]
        public bool? PublishedOnly { get; set; }

    }

}

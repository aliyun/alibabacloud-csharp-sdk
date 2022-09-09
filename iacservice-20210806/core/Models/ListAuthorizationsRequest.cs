// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListAuthorizationsRequest : TeaModel {
        [NameInMap("authorizationId")]
        [Validation(Required=false)]
        public string AuthorizationId { get; set; }

        [NameInMap("authorizationType")]
        [Validation(Required=false)]
        public string AuthorizationType { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

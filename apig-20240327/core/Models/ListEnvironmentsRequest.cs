// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListEnvironmentsRequest : TeaModel {
        [NameInMap("aliasLike")]
        [Validation(Required=false)]
        public string AliasLike { get; set; }

        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("gatewayNameLike")]
        [Validation(Required=false)]
        public string GatewayNameLike { get; set; }

        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}

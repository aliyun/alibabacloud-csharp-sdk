// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryMaterialListRequest : TeaModel {
        [NameInMap("CardNumber")]
        [Validation(Required=false)]
        public string CardNumber { get; set; }

        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public long? MaterialId { get; set; }

        [NameInMap("MaterialVersion")]
        [Validation(Required=false)]
        public string MaterialVersion { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public int? PrincipalName { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public int? Region { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("SystemVersion")]
        [Validation(Required=false)]
        public string SystemVersion { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}

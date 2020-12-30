// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class UpdateProfileCatalogRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IsvSubId")]
        [Validation(Required=false)]
        public string IsvSubId { get; set; }

        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public long? CatalogId { get; set; }

        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

    }

}

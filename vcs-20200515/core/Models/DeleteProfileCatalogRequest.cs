// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class DeleteProfileCatalogRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("IsvSubId")]
        [Validation(Required=false)]
        public string IsvSubId { get; set; }

        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

    }

}

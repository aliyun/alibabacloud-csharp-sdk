// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class CatalogInput : TeaModel {
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("LocationUri")]
        [Validation(Required=false)]
        public string LocationUri { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

    }

}

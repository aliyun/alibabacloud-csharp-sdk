// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class AlterCatalogResponseBody : TeaModel {
        [NameInMap("missing")]
        [Validation(Required=false)]
        public List<string> Missing { get; set; }

        [NameInMap("removed")]
        [Validation(Required=false)]
        public List<string> Removed { get; set; }

        [NameInMap("updated")]
        [Validation(Required=false)]
        public List<string> Updated { get; set; }

    }

}

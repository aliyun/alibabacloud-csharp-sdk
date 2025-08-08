// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CreateTableRequest : TeaModel {
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public Identifier Identifier { get; set; }

        [NameInMap("schema")]
        [Validation(Required=false)]
        public Schema Schema { get; set; }

    }

}

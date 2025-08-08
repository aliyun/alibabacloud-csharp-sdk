// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class AlterTableRequest : TeaModel {
        [NameInMap("changes")]
        [Validation(Required=false)]
        public List<FullSchemaChange> Changes { get; set; }

    }

}
